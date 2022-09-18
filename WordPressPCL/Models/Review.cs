using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Product Review
    /// </summary>
    public class Review : Base
    {
        /// <summary>
        /// The date the review was created, in the site's timezone.
        /// </summary>
        [JsonProperty("date_created", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// The date the review was created, as GMT.
        /// </summary>
        [JsonProperty("date_created_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateCreatedGMT { get; set; }
        /// <summary>
        /// Unique identifier for the product that the review belongs to.
        /// </summary>
        [JsonProperty("product_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ProductId { get; set; }
        /// <summary>
        /// Status of the review. Options: approved, hold, spam, unspam, trash and untrash. Defaults to approved.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        /// <summary>
        /// Reviewer name.
        /// </summary>
        [JsonProperty("reviewer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Reviewer { get; set; }
        /// <summary>
        /// Reviewer email.
        /// </summary>
        [JsonProperty("reviewer_email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ReviewerEmail { get; set; }
        /// <summary>
        /// The content of the review.
        /// </summary>
        [JsonProperty("review", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Content { get; set; }
        /// <summary>
        /// Review rating (0 to 5).
        /// </summary>
        [JsonProperty("rating", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? Rating { get; set; }
        /// <summary>
        /// Shows if the reviewer bought the product or not.
        /// </summary>
        [JsonProperty("verified", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Verified { get; set; }

        public Review() { }
    }
}
