using Newtonsoft.Json;

namespace Courier.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class PageDetails
    {

        /// <summary>
        /// 
        /// </summary>
        public string Cursor { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "more")]
        public bool MoreResults { get; set; }

    }

}
