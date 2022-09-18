using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Customer
    /// </summary>
    public class Customer : Base
    {
        /// <summary>
        /// The date the customer was created, in the site's timezone.
        /// </summary>
        [JsonProperty("date_created", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// The date the customer was created, as GMT.
        /// </summary>
        [JsonProperty("date_created_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateCreatedGMT { get; set; }
        /// <summary>
        /// The date the customer was last modified, in the site's timezone.
        /// </summary>
        [JsonProperty("date_modified", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateModified { get; set; }
        /// <summary>
        /// The date the customer was last modified, as GMT.
        /// </summary>
        [JsonProperty("date_modified_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateModifiedGMT { get; set; }
        /// <summary>
        /// The email address for the customer.
        /// </summary>
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }
        /// <summary>
        /// Customer first name.
        /// </summary>
        [JsonProperty("first_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }
        /// <summary>
        /// Customer last name.
        /// </summary>
        [JsonProperty("last_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }
        /// <summary>
        /// Customer role.
        /// </summary>
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Role { get; set; }
        /// <summary>
        /// Customer login name.
        /// </summary>
        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UserName { get; set; }
        /// <summary>
        /// Customer password.
        /// </summary>
        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Password { get; set; }
        /// <summary>
        /// List of billing address data
        /// </summary>
        [JsonProperty("billing", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Billing? Billing { get; set; }
        /// <summary>
        /// List of shipping address data.
        /// </summary>
        [JsonProperty("shipping", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShippingAddress? Shipping { get; set; }
        /// <summary>
        /// Is the customer a paying customer?
        /// </summary>
        [JsonProperty("is_paying_customer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsPayingCustomer { get; set; }
        /// <summary>
        /// Avatar URL.
        /// </summary>
        [JsonProperty("avatar_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AvatarUrl { get; set; }
        /// <summary>
        /// Meta data
        /// </summary>
        [JsonProperty("meta_data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<MetaData> Metadata { get; set; }

        public Customer() { }
    }
}
