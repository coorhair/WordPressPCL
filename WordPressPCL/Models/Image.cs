using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Product/Category Image
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Image ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// The date the image was created, in the site's timezone.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// The date the image was created, as GMT.
        /// </summary>
        [JsonProperty("date_created_gmt")]
        public DateTime DateCreatedGMT { get; set; }
        /// <summary>
        /// The date the image was last modified, in the site's timezone.
        /// </summary>
        [JsonProperty("date_modified")]
        public DateTime DateModified { get; set; }
        /// <summary>
        /// The date the image was last modified, as GMT.
        /// </summary>
        [JsonProperty("date_modified_gmt")]
        public DateTime DateModifiedGMT { get; set; }
        /// <summary>
        /// Image URL
        /// </summary>
        [JsonProperty("src")]
        public string Source { get; set; }
        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Image alternative text.
        /// </summary>
        [JsonProperty("alt")]
        public string AltText { get; set; }
    }
}
