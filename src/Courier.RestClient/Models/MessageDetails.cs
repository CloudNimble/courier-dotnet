using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace Courier.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class MessageDetails
    {

        #region Properties

        /// <summary>
        /// A UTC timestamp at which Courier received the message request. 
        /// </summary>
        [JsonProperty(PropertyName = "enqueued")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DateEnqueued { get; set; }

        /// <summary>
        /// A message describing the error that occurred.
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// A unique identifier associated with the event of the delivered message.
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// A message describing the error that occurred.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// A unique identifier associated with the notification of the delivered message.
        /// </summary>
        [JsonProperty(PropertyName = "sent")]
        public string NotificationId { get; set; }

        /// <summary>
        /// Contains a list of the last events for each provider within a channel.
        /// </summary>
        public List<ProviderDetails> Providers { get; set; }

        /// <summary>
        /// A unique identifier associated with the recipient of the delivered message.
        /// </summary>
        public string Recipient { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public MessageDetails()
        {
            Providers = new List<ProviderDetails>();
        }

        #endregion

    }

}
