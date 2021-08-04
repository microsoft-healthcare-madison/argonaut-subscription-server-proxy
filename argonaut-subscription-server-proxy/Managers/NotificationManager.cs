// <copyright file="NotificationManager.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace argonaut_subscription_server_proxy.Managers
{
    /// <summary>Manager for notifications.</summary>
    public class NotificationManager
    {
        /// <summary>The instance (singleton).</summary>
        private static NotificationManager _instance;

        /// <summary>The SendPulse email client.</summary>
        private SendPulse.Sendpulse _sendpulseClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationManager"/> class.
        /// </summary>
        private NotificationManager()
        {
            Console.WriteLine("Notification Service Started.");

            if (string.IsNullOrEmpty(Program.Configuration["Sendpulse_User_Id"]) ||
                string.IsNullOrEmpty(Program.Configuration["Sendpulse_Secret"]))
            {
                Console.WriteLine("Email information not found, will be disabled!");
                _sendpulseClient = null;
            }
            else
            {
                // create our email client
                _sendpulseClient = new SendPulse.Sendpulse(
                    Program.Configuration["Sendpulse_User_Id"],
                    Program.Configuration["Sendpulse_Secret"]);
            }
        }

        /// <summary>Initializes this object.</summary>
        public static void Init()
        {
            CheckOrCreateInstance();
        }

        /// <summary>Check or create instance.</summary>
        private static void CheckOrCreateInstance()
        {
            if (_instance == null)
            {
                _instance = new NotificationManager();
            }
        }

        /// <summary>Attempts to notify REST hook a Resource from the given Subscription.</summary>
        /// <param name="subscriptionId">        The subscription id.</param>
        /// <param name="endpoint">              The endpoint.</param>
        /// <param name="headers">               The headers.</param>
        /// <param name="json">                  The content.</param>
        /// <param name="contentTypeName">       Type of the content.</param>
        /// <param name="contentId">             [out] The bundle.</param>
        /// <param name="subscriptionEventCount">Number of bundle events.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        internal static bool TryNotifyRestHook(
            string subscriptionId,
            string endpoint,
            IEnumerable<string> headers,
            string json,
            string contentTypeName,
            string contentId,
            long subscriptionEventCount)
        {
            HttpRequestMessage request = null;

            // send the request to the endpoint
            try
            {
                // build our request
                request = new HttpRequestMessage()
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(endpoint),
                    Content = new StringContent(json, Encoding.UTF8, "application/fhir+json"),
                };

                // check for additional headers
                if ((headers != null) && headers.Any())
                {
                    // add headers
                    foreach (string header in headers)
                    {
                        if (string.IsNullOrEmpty(header))
                        {
                            continue;
                        }

                        // parse the existing header
                        int seperatorLoc = header.IndexOf(':', StringComparison.Ordinal);

                        if (seperatorLoc < 1)
                        {
                            continue;
                        }

                        // add this header (skip the seperator and the following space)
                        request.Headers.Add(header.Substring(0, seperatorLoc), header.Substring(seperatorLoc + 2));
                    }
                }

                // send our request
                HttpResponseMessage response = Program.RestClient.SendAsync(request).Result;

                // check the status code
                if ((response.StatusCode != System.Net.HttpStatusCode.OK) &&
                    (response.StatusCode != System.Net.HttpStatusCode.Accepted) &&
                    (response.StatusCode != System.Net.HttpStatusCode.NoContent))
                {
                    // failure
                    Console.WriteLine($"NotificationManager.TryNotifyRestHook <<< request to" +
                        $" {endpoint}" +
                        $" returned: {response.StatusCode}");

                    return false;
                }

                // tell the user
                if (string.IsNullOrEmpty(contentId))
                {
                    string messageType = (subscriptionEventCount == 0) ? "handshake" : "heartbeat";

                    Console.WriteLine($" <<< sent REST" +
                        $" {subscriptionId} ({endpoint})" +
                        $" a {messageType} message");
                }
                else
                {
                    Console.WriteLine($" <<< sent REST" +
                        $" {subscriptionId} ({endpoint})" +
                        $" notification for: {Program.UrlForR5ResourceId(contentTypeName, contentId)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SubscriptionManager.TryNotifyRestHook <<< request to" +
                    $" {endpoint}" +
                    $" caused exception: {ex.Message}");

                return false;
            }
            finally
            {
                if (request != null)
                {
                    request.Dispose();
                    request = null;
                }
            }

            return true;
        }

        /// <summary>Gets email text.</summary>
        /// <param name="content">               The content (empty/id-only/full-resource).</param>
        /// <param name="contentId">             [out] The bundle.</param>
        /// <param name="subscriptionEventCount">[out] Number of events.</param>
        /// <returns>The email text.</returns>
        internal static string GetEmailText(
                                    string content,
                                    string contentId,
                                    long subscriptionEventCount)
        {
            // check for no content
            if (string.IsNullOrEmpty(contentId) && (subscriptionEventCount == 0))
            {
                return "This is a handshake message";
            }

            if (string.IsNullOrEmpty(contentId))
            {
                return "This is a heartbeat message";
            }

            // act depending on payload type
            switch (content)
            {
                case fhirCsR5.ValueSets.SubscriptionPayloadContentCodes.LiteralEmpty:
                    return $"You have a new Health notification, please check with your provider via your portal.";

                case fhirCsR5.ValueSets.SubscriptionPayloadContentCodes.LiteralIdOnly:
                    return $"You have a new Health notification ({contentId}), please check with your provider via your portal.";

                case fhirCsR5.ValueSets.SubscriptionPayloadContentCodes.LiteralFullResource:
                    return "Picture it: a nice email relevant to this resource.";
            }

            return string.Empty;
        }

        /// <summary>
        /// SMTP send mail From:
        /// https://github.com/sendpulse/sendpulse-rest-api-csharp/blob/master/Sendpulse-rest-api/Examples.cs.
        /// </summary>
        /// <param name="sp">         The sp.</param>
        /// <param name="from_name">  Name of from.</param>
        /// <param name="from_email"> from email.</param>
        /// <param name="name_to">    The name to.</param>
        /// <param name="email_to">   The email to.</param>
        /// <param name="html">       The HTML.</param>
        /// <param name="text">       The text.</param>
        /// <param name="subject">    The subject.</param>
        /// <param name="attachments">The attachments.</param>
        internal static void smtpSendMail(
            SendPulse.Sendpulse sp,
            string from_name,
            string from_email,
            string name_to,
            string email_to,
            string html,
            string text,
            string subject,
            Dictionary<string, string> attachments)
        {
            Dictionary<string, object> from = new Dictionary<string, object>();
            from.Add("name", from_name);
            from.Add("email", from_email);
            ArrayList to = new ArrayList();
            Dictionary<string, object> elementto = new Dictionary<string, object>();
            elementto.Add("name", name_to);
            elementto.Add("email", email_to);
            to.Add(elementto);
            Dictionary<string, object> emaildata = new Dictionary<string, object>();
            emaildata.Add("html", html);
            emaildata.Add("text", text);
            emaildata.Add("subject", subject);
            emaildata.Add("from", from);
            emaildata.Add("to", to);
            if (attachments.Count > 0)
            {
                emaildata.Add("attachments_binary", attachments);
            }

            Dictionary<string, object> result = sp.smtpSendMail(emaildata);
            Console.WriteLine($"Response Status {result["http_code"]}");
            Console.WriteLine($"Result {result["data"]}");
            Console.ReadKey();
        }

        /// <summary>Attempts to notify email a Resource from the given Subscription.</summary>
        /// <param name="subscriptionId">        The subscription id.</param>
        /// <param name="endpoint">              The endpoint.</param>
        /// <param name="contentMimeType">       MIME type of the content.</param>
        /// <param name="content">               The content (empty/id-only/full-resource).</param>
        /// <param name="json">                  The content.</param>
        /// <param name="contentTypeName">       Name of the content type.</param>
        /// <param name="contentId">             [out] The bundle.</param>
        /// <param name="subscriptionEventCount">Number of bundle events.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        internal static bool TryNotifyEmail(
            string subscriptionId,
            string endpoint,
            string contentMimeType,
            string content,
            string json,
            string contentTypeName,
            string contentId,
            long subscriptionEventCount)
        {
            if (_instance._sendpulseClient == null)
            {
                Console.WriteLine($" <<< attempted EMAIL" +
                    $" {subscriptionId} ({endpoint})" +
                    $" NOT SENT!");
                return false;
            }

            // send the request to the endpoint
            try
            {
                // grab mime type
                string mimeType = contentMimeType.ToLowerInvariant();

                string body = string.Empty;

                // act on mime type
                if (mimeType.StartsWith("text/plain", StringComparison.Ordinal))
                {
                    body = GetEmailText(content, contentId, subscriptionEventCount);
                }

                if (mimeType.StartsWith("text/html", StringComparison.Ordinal))
                {
                    body = GetEmailText(content, contentId, subscriptionEventCount);
                }

                // check for attachments
                Dictionary<string, string> attachments = new Dictionary<string, string>();

                if (mimeType.Contains("attach", StringComparison.Ordinal))
                {
                    // convert to base 64
                    string attachmentBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));

                    // add our attachment
                    attachments.Add("fhirBundle.json", attachmentBase64);
                }

                // check for handshake
                if (subscriptionEventCount == 0)
                {
                    // send our email message
                    smtpSendMail(
                        _instance._sendpulseClient,
                        "Argonaut Subscriptions",
                        Program.Configuration["Sendpulse_Sender"],
                        endpoint,
                        endpoint,
                        $"Subscription: {subscriptionId} on server: {Program.Configuration["Server_Public_Url"]}",
                        $"Subscription: {subscriptionId} on server: {Program.Configuration["Server_Public_Url"]}",
                        $"FHIR Notification - {subscriptionId} - New Registration",
                        attachments);

                    Console.WriteLine($" <<< sent EMAIL" +
                        $" {subscriptionId} ({endpoint})" +
                        $" a handshake message");

                    return true;
                }

                // check for heartbeat
                if (string.IsNullOrEmpty(json) && (subscriptionEventCount != 0))
                {
                    // send our email message
                    smtpSendMail(
                        _instance._sendpulseClient,
                        "Argonaut Subscriptions",
                        Program.Configuration["Sendpulse_Sender"],
                        endpoint,
                        endpoint,
                        $"Subscription: {subscriptionId} on server: {Program.Configuration["Server_Public_Url"]}.  Letting you know nothing has happened.",
                        $"Subscription: {subscriptionId} on server: {Program.Configuration["Server_Public_Url"]}.  Letting you know nothing has happened.",
                        $"FHIR Notification - {subscriptionId} - Nothing New",
                        attachments);

                    Console.WriteLine($" <<< sent EMAIL" +
                        $" {subscriptionId} ({endpoint})" +
                        $" a heartbeat message");

                    return true;
                }

                // send our email message
                smtpSendMail(
                    _instance._sendpulseClient,
                    "Argonaut Subscriptions",
                    Program.Configuration["Sendpulse_Sender"],
                    endpoint,
                    endpoint,
                    mimeType.StartsWith("text/html", StringComparison.Ordinal) ? body : string.Empty,
                    mimeType.StartsWith("text/plain", StringComparison.Ordinal) ? body : string.Empty,
                    $"FHIR Notification - {subscriptionId} - {Program.UrlForR5ResourceId(contentTypeName, contentId)}",
                    attachments);

                Console.WriteLine($" <<< sent EMAIL" +
                    $" {subscriptionId} ({endpoint})" +
                    $" notification for: {Program.UrlForR5ResourceId(contentTypeName, contentId)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SubscriptionManager.TryNotifyEmail <<< request to" +
                    $" {endpoint}" +
                    $" caused exception: {ex.Message}");

                return false;
            }

            return true;
        }
    }
}
