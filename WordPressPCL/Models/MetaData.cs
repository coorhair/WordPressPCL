using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// Use in WooCommerce
    /// </summary>
    public class MetaData
    {
        /// <summary>
        /// Meta ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// Meta key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }
        /// <summary>
        /// Meta value
        /// </summary>
        [JsonProperty("value")]
        public dynamic Value { get; set; }
    }
}
