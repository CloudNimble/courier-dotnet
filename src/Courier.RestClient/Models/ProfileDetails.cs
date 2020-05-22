using Newtonsoft.Json;

namespace Courier.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class ProfileDetails
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "phone_number")]
        public string PhoneNumber { get; set; }

    }
}
