using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Product default Attribute
    /// </summary>
    public class DefaultAttribute
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
        /// Selected attribute term name.
        /// </summary>
        [JsonProperty("option")]
        public string Option { get; set; }
    }
}
