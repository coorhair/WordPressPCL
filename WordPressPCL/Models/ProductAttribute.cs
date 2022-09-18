using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Product Attribute
    /// </summary>
    public class ProductAttribute
    {
        /// <summary>
        /// Attribute ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// Attribute name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Attribute position.
        /// </summary>
        [JsonProperty("position")]
        public int? Position { get; set; }
        /// <summary>
        /// Define if the attribute is visible on the "Additional information" tab in the product's page. Default is false.
        /// </summary>
        [JsonProperty("visible")]
        public bool Visible { get; set; }
        /// <summary>
        /// Define if the attribute can be used as variation. Default is false
        /// </summary>
        [JsonProperty("variation")]
        public bool Variation { get; set; }
        /// <summary>
        /// List of available term names of the attribute.
        /// </summary>
        [JsonProperty("options")]
        public IEnumerable<string> Options { get; set; }
    }
}
