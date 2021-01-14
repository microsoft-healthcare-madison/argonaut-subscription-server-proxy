// <copyright file="WebsocketHeartbeatService.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using argonaut_subscription_server_proxy.Managers;
using argonaut_subscription_server_proxy.Models;
using Hl7.Fhir.Utility;
using Microsoft.Extensions.Hosting;

namespace argonaut_subscription_server_proxy.Services
{
    /// <summary>A service for accessing web socket keep alives information.</summary>
    public class WebsocketHeartbeatService : IHostedService, IDisposable
    {
        /// <summary>The FHIR R4 clients and timeouts.</summary>
        private ConcurrentDictionary<Guid, long> _r4ClientsAndTimeouts;

        /// <summary>The FHIR R5 clients and timeouts.</summary>
        private ConcurrentDictionary<Guid, long> _r5ClientsAndTimeouts;

        /// <summary>The callback timer.</summary>
        private Timer _timer;
        private bool _disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsocketHeartbeatService"/> class.
        /// </summary>
        public WebsocketHeartbeatService()
        {
        }

        private void CheckAndSendHeartbeats(object state)
        {
            long currentTicks = DateTime.Now.Ticks;
            string heartbeatTime = string.Format(CultureInfo.InvariantCulture, "{0:o}", DateTime.Now.ToUniversalTime());

            ProcessHeartbeats(_r4ClientsAndTimeouts, currentTicks, heartbeatTime);
            ProcessHeartbeats(_r5ClientsAndTimeouts, currentTicks, heartbeatTime);
        }

        /// <summary>Process the heartbeats.</summary>
        /// <param name="clientsAndTimeouts">The clients and timeouts.</param>
        /// <param name="currentTicks">      The current ticks.</param>
        /// <param name="heartbeatTime">     The heartbeat time.</param>
        private void ProcessHeartbeats(
            ConcurrentDictionary<Guid, long> clientsAndTimeouts,
            long currentTicks,
            string heartbeatTime)
        {
            if (_r4ClientsAndTimeouts.IsEmpty)
            {
                return;
            }

            List<Guid> clientsToRemove = new List<Guid>();

            // traverse the dictionary looking for clients we need to send messages to
            foreach (KeyValuePair<Guid, long> kvp in clientsAndTimeouts)
            {
                // check timeout
                if (currentTicks > kvp.Value)
                {
                    // enqueue a message for this client
                    if (WebsocketManager.TryGetClient(kvp.Key, out WebsocketClientInformation client))
                    {
                        // enqueue a keepalive message
                        client.MessageQ.Enqueue($"heartbeat {heartbeatTime}");
                    }
                    else
                    {
                        // client is gone, stop sending (cannot remove inside iterator)
                        clientsToRemove.Add(kvp.Key);
                    }
                }
            }

            if (!clientsToRemove.IsNullOrEmpty())
            {
                foreach (Guid clientGuid in clientsToRemove)
                {
                    clientsAndTimeouts.TryRemove(clientGuid, out _);
                }
            }
        }

        /// <summary>Triggered when the application host is ready to start the service.</summary>
        /// <param name="cancellationToken">Indicates that the start process has been aborted.</param>
        /// <returns>An asynchronous result.</returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Websocket Keepalive Service Started.");

            _r4ClientsAndTimeouts = new ConcurrentDictionary<Guid, long>();
            _r5ClientsAndTimeouts = new ConcurrentDictionary<Guid, long>();

            _timer = new Timer(
                CheckAndSendHeartbeats,
                null,
                TimeSpan.Zero,
                TimeSpan.FromSeconds(1));

            return Task.CompletedTask;
        }

        /// <summary>Triggered when the application host is performing a graceful shutdown.</summary>
        /// <param name="cancellationToken">Indicates that the shutdown process should no longer be
        ///  graceful.</param>
        /// <returns>An asynchronous result.</returns>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        /// <summary>
        /// Releases the unmanaged resources used by the
        /// argonaut_subscription_server_proxy.Services.WebsocketHeartbeatService and optionally releases
        /// the managed resources.
        /// </summary>
        /// <param name="disposing">True to release both managed and unmanaged resources; false to
        ///  release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _timer?.Dispose();
                }

                _r4ClientsAndTimeouts = null;
                _r5ClientsAndTimeouts = null;

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
