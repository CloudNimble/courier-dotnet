using Courier.Models.Requests;
using Courier.Models.Responses;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PortableRest;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Courier
{

    /// <summary>
    /// 
    /// </summary>
    public class CourierClient : RestClient
    {

        #region Constants


        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        public CourierClient(string apiKey) : base()
        {
            // RWM: https://www.newtonsoft.com/json/help/html/NamingStrategyCamelCase.htm
            JsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                },
                NullValueHandling = NullValueHandling.Ignore
            };
            AddHeader("Authorization", $"Bearer {apiKey}");
            BaseUrl = "https://api.trycourier.app/";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="handler"></param>
        public CourierClient(string apiKey, HttpMessageHandler handler) : this(apiKey)
        {
            HttpHandler = handler;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The Enrichment API lets you look up person and company data based on an email or domain. For example, you could retrieve a person’s name, location 
        /// and social handles from an email. Or you could lookup a company’s location, headcount or logo based on their domain name.
        /// </summary>
        /// <param name="sendMessageRequest"></param>
        /// <returns></returns>
        /// <remarks>
        /// Note: You’ll only be charged once per 30 day period for each unique request, so if you didn’t store the data properly or need to re-run a series of 
        /// requests for any reason, those won’t count against your allotment.
        /// </remarks>
        public async Task<RestResponse<SendMessageResponse>> SendMessageAsync(SendMessageRequest sendMessageRequest)
        {
            if (sendMessageRequest == null)
            {
                throw new ArgumentNullException(nameof(sendMessageRequest));
            }

            var request = new RestRequest("send", HttpMethod.Post, ContentTypes.Json);
            request.AddParameter(sendMessageRequest);
            return await SendAsync<SendMessageResponse>(request).ConfigureAwait(false);
        }

        #endregion

        #region Private Methods



        #endregion

    }

}
