using Newtonsoft.Json;
using System.Collections.Generic;

namespace Courier.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class PagedResults<T> where T : class
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "paging")]
        public PageDetails PageDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<T> Results { get; set; }

    }

}
