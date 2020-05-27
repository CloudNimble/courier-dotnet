using Newtonsoft.Json;

namespace Courier.Models.Requests
{

    /// <summary>
    /// </summary>
    public class SendMessageRequest
    {

        #region Public Properties

        /// <summary>
        /// A unique identifier that can be mapped to an individual Notification. This could be the "Notification ID” on Notification 
        /// detail pages (see the Notifications page in the Courier app) or a custom string mapped to the event in settings.
        /// </summary>
        [JsonProperty(PropertyName = "event")]
        public string EventName { get; set; }

        /// <summary>
        /// An object that is merged into the request sent by Courier to the provider to override properties or to gain access to 
        /// features in the provider API that are not natively supported by Courier.
        /// </summary>
        [JsonProperty(PropertyName = "override")]
        public object ProviderOverrides { get; set; }

        /// <summary>
        /// An object that includes any key-value pairs required by your chosen Integrations (see our Provider Documentation for the 
        /// requirements for each Integration.) If profile information is included in the request and that information already exists 
        /// in the profile for the recipientId, that information will be merged.
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public IProviderProfile ProviderProfile { get; set; }

        /// <summary>
        /// A unique identifier associated with the recipient of the delivered message.
        /// </summary>
        [JsonProperty(PropertyName = "recipient")]
        public string RecipientId { get; set; }

        /// <summary>
        /// An object that includes any preferences for the recipient.
        /// </summary>
        [JsonProperty(PropertyName = "preferences")]
        public dynamic RecipientPreferences { get; set; }

        /// <summary>
        /// An object that includes any data you want to pass to a message template. The data will populate the corresponding 
        /// template variables.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public ITemplateData TemplateData { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="recipientId"></param>
        public SendMessageRequest(string eventName, string recipientId)
        {
            EventName = eventName;
            RecipientId = recipientId;
        }

        #endregion

    }

}
