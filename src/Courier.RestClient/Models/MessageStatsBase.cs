using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Courier.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class MessageStatsBase
    {

        /// <summary>
        /// A UTC timestamp at which the recipient clicked on a tracked link for the first time.
        /// </summary>
        [JsonProperty(PropertyName = "clicked")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DateClicked { get; set; }

        /// <summary>
        /// A UTC timestamp at which the Integration provider delivered the message.
        /// </summary>
        [JsonProperty(PropertyName = "delivered")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DateDelivered { get; set; }

        /// <summary>
        /// A UTC timestamp at which Courier passed the message to the Integration provider.
        /// </summary>
        [JsonProperty(PropertyName = "sent")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DateSent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public MessageStatus Status { get; set; }

    }

}
