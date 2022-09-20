using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Category
    /// </summary>
    public class ProductCategory : Base
    {
        /// <summary>
        /// Category name
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        /// <summary>
        /// Category slug
        /// </summary>
        [JsonProperty("slug")]
        public string? Slug { get; set; }
        /// <summary>
        /// The ID for the parent of the resource.
        /// </summary>
        [JsonProperty("parent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? Parent { get; set; }
        /// <summary>
        /// HTML description of the resource.
        /// </summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Description { get; set; }
        /// <summary>
        /// Category archive display type. Options: default, products, subcategories and both. Default is default
        /// </summary>
        [JsonProperty("display", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Display { get; set; }
        /// <summary>
        /// Image data. 
        /// </summary>
        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Image? Image { get; set; }
        /// <summary>
        /// Menu order, used to custom sort the resource.
        /// </summary>
        [JsonProperty("menu_order", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? MenuOrder { get; set; }
        /// <summary>
        /// Number of published products for the resource.
        /// </summary>
        [JsonProperty("count", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? Count { get; set; }
    }
}
