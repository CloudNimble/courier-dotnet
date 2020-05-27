using Newtonsoft.Json;

namespace Courier.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class ProviderDetails : MessageStatsBase
    {

        /// <summary>
        /// 
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public ChannelDetails ChannelDetails { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "reference")]
        public dynamic ReferenceIds { get; set; }

    }

}
