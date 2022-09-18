using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Product Download
    /// </summary>
    public class Download
    {
        /// <summary>
        /// File ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// File name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// File URL
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; }
    }
}
