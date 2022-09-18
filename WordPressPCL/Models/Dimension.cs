using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Product Dimension
    /// </summary>
    public class Dimension
    {
        /// <summary>
        /// Product length
        /// </summary>
        [JsonProperty("length")]
        public string Length { get; set; }
        /// <summary>
        /// Product width
        /// </summary>
        [JsonProperty("width")]
        public string Width { get; set; }
        /// <summary>
        /// Product height
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; }
    }
}
