﻿// <copyright file="SubscriptionWebsocketHandler.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using argonaut_subscription_server_proxy.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace argonaut_subscription_server_proxy.Handlers
{
    /// <summary>A subscription websocket handler.</summary>
    public class SubscriptionWebsocketHandler : IDisposable
    {
        /// <summary>Size of the message buffer.</summary>
        private const int _messageBufferSize = 1024 * 8;            // 8 KB

        /// <summary>The send sleep delay in milliseconds.</summary>
        private const int _sendSleepDelayMs = 100;

        /// <summary>   The configuration. </summary>
        private readonly IConfiguration _config;

        /// <summary>The next delegate.</summary>
        private readonly RequestDelegate _nextDelegate;

        /// <summary>A token that allows processing to be cancelled.</summary>
        private readonly CancellationToken _applicationStopping;

        /// <summary>Dictionary of client message timeouts.</summary>
        private ConcurrentDictionary<Guid, long> _clientMessageTimeoutDict;

        /// <summary>URL to match.</summary>
        private readonly string _matchUrl;

        /// <summary>The keepalive cancel source.</summary>
        private CancellationTokenSource _keepaliveCancelSource;

        /// <summary>The keepalive lock object.</summary>
        private object _keepaliveLockObject;

        /// <summary>If this object has been disposed.</summary>
        private bool _disposedValue;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SubscriptionWebsocketHandler"/> class.
        /// </summary>
        /// <param name="nextDelegate">  The next delegate in the process chain.</param>
        /// <param name="appLifetime">   The application lifetime.</param>
        /// <param name="iConfiguration">Reference to application configuration.</param>
        /// <param name="matchUrl">      URL to match.</param>
        public SubscriptionWebsocketHandler(
            RequestDelegate nextDelegate,
            IHostApplicationLifetime appLifetime,
            IConfiguration iConfiguration,
            string matchUrl)
        {
            if (appLifetime == null)
            {
                throw new ArgumentNullException(nameof(appLifetime));
            }

            _config = iConfiguration;
            _nextDelegate = nextDelegate;
            _applicationStopping = appLifetime.ApplicationStopping;
            _matchUrl = matchUrl;

            _clientMessageTimeoutDict = new ConcurrentDictionary<Guid, long>();
            _keepaliveCancelSource = new CancellationTokenSource();
            _keepaliveLockObject = new object();
        }

        /// <summary>Executes the asynchronous on a different thread, and waits for the result.</summary>
        /// <param name="context">The context.</param>
        /// <returns>An asynchronous result.</returns>
        public async Task InvokeAsync(HttpContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            // check for requests to our URL
            if (!context.Request.Path.Equals(_matchUrl, StringComparison.OrdinalIgnoreCase))
            {
                // pass to next caller in chain
                await _nextDelegate.Invoke(context).ConfigureAwait(false);
                return;
            }

            // check for not being a WebSocket request
            if (!context.WebSockets.IsWebSocketRequest)
            {
                Console.WriteLine($" <<< Received non-websocket request at: {_matchUrl}");
                context.Response.StatusCode = 400;
                return;
            }

            string payloadType = string.Empty;

            // check for specified payload type
            if (context.Request.Query.ContainsKey("payload-type"))
            {
                payloadType = context.Request.Query["payload-type"];
            }

            // figure out the websocket payload type
            switch (payloadType)
            {
                case WebsocketClientInformation.WebsocketPayloadTypes.Empty:
                    break;
                case WebsocketClientInformation.WebsocketPayloadTypes.IdOnly:
                    break;
                case WebsocketClientInformation.WebsocketPayloadTypes.FullResource:
                    break;
                case WebsocketClientInformation.WebsocketPayloadTypes.R4:
                    break;
                default:
                    // assume R4
                    payloadType = WebsocketClientInformation.WebsocketPayloadTypes.R4;
                    break;
            }

            // create our management record
            WebsocketClientInformation client = new WebsocketClientInformation()
            {
                Uid = Guid.NewGuid(),
                PayloadType = payloadType,
                MessageQ = new ConcurrentQueue<string>(),
                SubscriptionIdSet = new HashSet<string>(),
            };

            // accept this connection
            await AcceptAndProcessWebSocket(context, client).ConfigureAwait(false);
        }

        /// <summary>Tests queueing messages.</summary>
        /// <param name="clientGuid">Unique identifier for the client.</param>
        private static void TestQueueingMessages(Guid clientGuid)
        {
            bool done = false;
            long messageNumber = 0;

            while (!done)
            {
                // check for no client
                if (!WebsocketManager.TryGetClient(clientGuid, out WebsocketClientInformation client))
                {
                    // done
                    done = true;
                    continue;
                }

                // queue a message for this client
                client.MessageQ.Enqueue($"Test message: {messageNumber++}, {DateTime.Now}");

                // wait a couple of seconds
                Thread.Sleep(2000);
            }
        }

        /// <summary>Accept and process web socket.</summary>
        /// <param name="context">The context.</param>
        /// <param name="client"> The client.</param>
        /// <returns>An asynchronous result.</returns>
        private async Task AcceptAndProcessWebSocket(
            HttpContext context,
            WebsocketClientInformation client)
        {
            // prevent WebSocket errors from bubbling up
            try
            {
                // accept the connection
                using (var webSocket = await context.WebSockets.AcceptWebSocketAsync().ConfigureAwait(false))
                {
                    // register our client
                    WebsocketManager.RegisterClient(client);

                    // create a cancellation token source so we can cancel our read/write tasks
                    using (CancellationTokenSource processCancelSource = new CancellationTokenSource())

                    // link our local close with the application lifetime close for simplicity
                    using (CancellationTokenSource linkedSource =
                        CancellationTokenSource.CreateLinkedTokenSource(_applicationStopping, processCancelSource.Token))
                    {
                        CancellationToken cancelToken = linkedSource.Token;

                        Task[] webSocketTasks = new Task[2];

                        // create send task
                        webSocketTasks[0] = Task.Run(async () =>
                        {
                            try
                            {
                                await WriteClientMessages(webSocket, client.Uid, cancelToken).ConfigureAwait(false);
                            }
                            finally
                            {
                                // cancel read if write task has exited
                                processCancelSource.Cancel();
                            }
                        });

                        // create receive task
                        webSocketTasks[1] = Task.Run(async () =>
                        {
                            try
                            {
                                await ReadClientMessages(webSocket, client.Uid, cancelToken).ConfigureAwait(false);
                            }
                            finally
                            {
                                // cancel write if read task has exited
                                processCancelSource.Cancel();
                            }
                        });

                        // start tasks and wait for them to complete
                        await Task.WhenAll(webSocketTasks).ConfigureAwait(false);

                        // close our web socket (do not allow cancel)
                        await webSocket.CloseAsync(
                            WebSocketCloseStatus.EndpointUnavailable,
                            "Connection closing",
                            CancellationToken.None).ConfigureAwait(false);
                    }
                }
            }
            catch (WebSocketException wsEx)
            {
                // just log for now
                Console.WriteLine($" <<< caught exception: {wsEx.Message}");
            }
            finally
            {
                WebsocketManager.UnregisterClient(client.Uid);
            }

            return;
        }

        /// <summary>Write client messages.</summary>
        /// <param name="webSocket">  The web socket.</param>
        /// <param name="clientGuid"> Unique identifier for the client.</param>
        /// <param name="cancelToken">A token that allows processing to be canceled.</param>
        /// <returns>An asynchronous result.</returns>
        private static async Task WriteClientMessages(
            WebSocket webSocket,
            Guid clientGuid,
            CancellationToken cancelToken)
        {
            // get the client object
            if (!WebsocketManager.TryGetClient(clientGuid, out WebsocketClientInformation client))
            {
                // nothing to do here (will cancel on exit)
                return;
            }

            string message = string.Empty;

            while (!cancelToken.IsCancellationRequested)
            {
                // do not bubble errors here
                try
                {
                    // check for a message
                    if (!client.MessageQ.TryDequeue(out message))
                    {
                        try
                        {
                            await Task.Delay(_sendSleepDelayMs, cancelToken).ConfigureAwait(true);
                        }
                        finally
                        {
                            // ignore errors
                        }

                        // go to next loop
                        continue;
                    }

                    // grab a byte buffer of our data
                    byte[] buffer = Encoding.UTF8.GetBytes(message);

                    // send this message
                    await webSocket.SendAsync(
                        buffer,
                        WebSocketMessageType.Text,
                        true,
                        cancelToken).ConfigureAwait(false);

                    WebsocketManager.UpdateTimeoutForSentMessage(clientGuid);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"SubscriptionWebsocketHandler.WriteClientMessages" +
                        $" <<< client: {clientGuid} caught exception: {ex.Message}");

                    if (ex.InnerException != null)
                    {
                        Console.WriteLine($" <<< websocket inner exception: {ex.InnerException.Message}");
                    }

                    if (!string.IsNullOrEmpty(message))
                    {
                        Console.WriteLine($" <<< message being written: {message}");
                    }

                    // this socket is borked, exit
                    break;
                }
            }
        }

        /// <summary>Reads client messages.</summary>
        /// <param name="webSocket">  The web socket.</param>
        /// <param name="clientGuid"> Unique identifier for the client.</param>
        /// <param name="cancelToken">A token that allows processing to be cancelled.</param>
        /// <returns>An asynchronous result.</returns>
        private static async Task ReadClientMessages(
            WebSocket webSocket,
            Guid clientGuid,
            CancellationToken cancelToken)
        {
            if (!WebsocketManager.TryGetClient(clientGuid, out WebsocketClientInformation client))
            {
                // nothing to do here (will cancel on exit)
                return;
            }

            // create our receive buffer
            byte[] buffer = new byte[_messageBufferSize];
            int count;
            int messageLength = 0;

            WebSocketReceiveResult result;

            // loop until cancelled
            while (!cancelToken.IsCancellationRequested)
            {
                // reset buffer offset
                messageLength = 0;

                // do not bubble errors here
                try
                {
                    // read a message
                    do
                    {
                        count = _messageBufferSize - messageLength;
                        result = await webSocket.ReceiveAsync(
                                    new ArraySegment<byte>(
                                        buffer,
                                        messageLength,
                                        count),
                                    cancelToken).ConfigureAwait(false);
                        messageLength += result.Count;
                    }
                    while (!result.EndOfMessage);

                    // process this message
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        break;
                    }

                    // check for a bind request
                    string message = Encoding.UTF8.GetString(buffer).Substring(0, messageLength);
                    if (string.IsNullOrEmpty(message))
                    {
                        continue;
                    }

                    string[] words = message.Split(' ');
                    string[] ids;

                    switch (words[0])
                    {
                        case "bind":
                            // grab the rest of the content
                            message = message.Replace("bind ", string.Empty, StringComparison.Ordinal);

                            ids = message.Split(',');

                            // traverse the requested ids
                            foreach (string id in ids)
                            {
                                string subscriptionId = id.StartsWith("Subscription/", StringComparison.Ordinal)
                                    ? id.Replace("Subscription/", string.Empty, StringComparison.Ordinal)
                                    : id;

                                // make sure this subscription exists
                                if ((!SubscriptionManagerR4.Exists(subscriptionId)) &&
                                    (!SubscriptionManagerR5.Exists(subscriptionId)))
                                {
                                    Console.WriteLine($"WebsocketHandler.ReadClientMessages <<< attempt to bind to unknown subscription: {subscriptionId}");
                                    continue;
                                }

                                Console.WriteLine($"WebsocketHandler.ReadClientMessages <<< client {clientGuid} bound to {subscriptionId}");

                                // register this subscription to this client
                                WebsocketManager.AddSubscriptionToClient(subscriptionId, clientGuid);
                            }

                            break;

                        case "bind-with-token":
                            // grab the rest of the content
                            message = message.Replace("bind-with-token ", string.Empty, StringComparison.Ordinal);

                            if (!Guid.TryParse(message, out Guid tokenGuid))
                            {
                                Console.WriteLine($"WebsocketHandler.ReadClientMessages <<< client {clientGuid} attempting to bind with invalid token: {message}");
                                continue;
                            }

                            Console.WriteLine($"WebsocketHandler.ReadClientMessages <<< client {clientGuid} bound with token {tokenGuid}");

                            // register this token to this client
                            WebsocketManager.BindClientWithToken(tokenGuid, clientGuid);
                            break;

                        case "unbind":
                            // grab the rest of the content
                            message = message.Replace("unbind ", string.Empty, StringComparison.Ordinal);

                            ids = message.Split(',');

                            // traverse the requested ids
                            foreach (string id in ids)
                            {
                                string subscriptionId = id.StartsWith("Subscription/", StringComparison.Ordinal)
                                    ? id.Replace("Subscription/", string.Empty, StringComparison.Ordinal)
                                    : id;

                                Console.WriteLine($"WebsocketHandler.ReadClientMessages <<< client {clientGuid} unbound from subscription {subscriptionId}");

                                // remove this subscription from this client
                                WebsocketManager.RemoveSubscriptionFromClient(subscriptionId, clientGuid);
                            }

                            break;

                        default:
                            Console.WriteLine($"WebsocketHandler.ReadClientMessages <<< unknown message: >>>{message}<<<");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"SubscriptionWebsocketHandler.ReadClientMessages" +
                        $" <<< client: {clientGuid} caught exception: {ex.Message}");

                    // this socket is borked, exit
                    break;
                }
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged
        /// resources.
        /// </summary>
        /// <param name="disposing">True to release both managed and unmanaged resources; false to
        ///  release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects)
                    _keepaliveCancelSource.Dispose();
                    _keepaliveCancelSource = null;
                }

                // free unmanaged resources (unmanaged objects) and override finalizer
                // set large fields to null
                _disposedValue = true;
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged
        /// resources.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
