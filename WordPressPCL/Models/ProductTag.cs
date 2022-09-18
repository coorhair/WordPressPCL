using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Product Tag
    /// </summary>
    public class ProductTag
    {
        /// <summary>
        /// Tag ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// Tag name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Tag slug
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
