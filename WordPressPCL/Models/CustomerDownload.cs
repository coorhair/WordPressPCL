using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Customer Download
    /// </summary>
    public class CustomerDownload
    {
        /// <summary>
        /// Download ID (MD5).
        /// </summary>
        [JsonProperty("download_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DownloadId { get; set; }
        /// <summary>
        /// Download file URL.
        /// </summary>
        [JsonProperty("download_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DownloadUrl { get; set; }
        /// <summary>
        /// Downloadable product ID.
        /// </summary>
        [JsonProperty("product_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ProductId { get; set; }
        /// <summary>
        /// Product name.
        /// </summary>
        [JsonProperty("product_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ProductName { get; set; }
        /// <summary>
        /// Downloadable file name.
        /// </summary>
        [JsonProperty("download_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DownloadName { get; set; }
        /// <summary>
        /// Order ID.
        /// </summary>
        [JsonProperty("order_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? OrderId { get; set; }
        /// <summary>
        /// Order key.
        /// </summary>
        [JsonProperty("order_key", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OrderKey { get; set; }
        /// <summary>
        /// Number of downloads remaining.
        /// </summary>
        [JsonProperty("downloads_remaining", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DownloadsRemaining { get; set; }
        /// <summary>
        /// The date when download access expires, in the site's timezone.
        /// </summary>
        [JsonProperty("access_expires", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccessExpires { get; set; }
        /// <summary>
        /// The date when download access expires, as GMT.
        /// </summary>
        [JsonProperty("access_expires_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccessExpiresGMT { get; set; }
        /// <summary>
        /// File details
        /// </summary>
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CustomerDownloadFileProperty? File { get; set; }
    }

    /// <summary>
    /// Customer Download File detail (WooCommerce)
    /// </summary>
    public class CustomerDownloadFileProperty
    {
        /// <summary>
        /// File name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// File URL
        /// </summary>
        [JsonProperty("file")]
        public string Url { get; set; }
    }
}
