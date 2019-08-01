using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using ProxyKit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace argonaut_subscription_server_proxy.ResourceProcessors
{
    public class EncounterProcessor
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>Process the request.</summary>
        ///
        /// <remarks>Gino Canessa, 8/1/2019.</remarks>
        ///
        /// <param name="appInner">     The application inner.</param>
        /// <param name="fhirServerUrl">URL of the fhir server.</param>
        ///-------------------------------------------------------------------------------------------------

        public static void ProcessRequest(IApplicationBuilder appInner, string fhirServerUrl)
        {
            //// **** run the proxy for this request ****

            //appInner.RunProxy(async context => {
            //    // **** grab a formatted copy of this request for proxying ****

            //    //ForwardContext proxiedContext = context.ForwardTo(fhirServerUrl);

            //    HttpResponseMessage response = new HttpResponseMessage();

            //    // **** return appropriate code to the caller ****

            //    switch (context.Request.Method.ToUpper())
            //    {
            //        case "GET":

            //            // *** success ****

            //            response.Content = new StringContent(JsonConvert.SerializeObject(TopicManager.GetTopicList()));
            //            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //            response.StatusCode = System.Net.HttpStatusCode.OK;

            //            break;

            //        case "PUT":

            //            // *** success ****

            //            response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

            //            break;

            //        case "POST":

            //            // **** grab the message body to look at ****

            //            System.IO.StreamReader requestReader = new System.IO.StreamReader(context.Request.Body);
            //            string requestContent = requestReader.ReadToEnd();

            //            response.Content = new StringContent(requestContent);

            //            // *** not implemented yet ****

            //            response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

            //            break;

            //        case "DELETE":

            //            // *** success ****

            //            response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

            //            break;

            //        default:

            //            // **** tell client we didn't understand ****

            //            response.StatusCode = System.Net.HttpStatusCode.NotImplemented;

            //            break;
            //    }

            //    return response;
            //});
        }
    }
}
