using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Coupon
    /// </summary>
    public class Coupon : Base
    {
        /// <summary>
        /// Coupon code.
        /// </summary>
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Code { get; set; }
        /// <summary>
        /// The amount of discount. Should always be numeric, even if setting a percentage.
        /// </summary>
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Amount { get; set; }
        /// <summary>
        /// The date the coupon was created, in the site's timezone.
        /// </summary>
        [JsonProperty("date_created", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// The date the coupon was created, as GMT.
        /// </summary>
        [JsonProperty("date_created_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateCreatedGMT { get; set; }
        /// <summary>
        /// The date the coupon was last modified, in the site's timezone.
        /// </summary>
        [JsonProperty("date_modified", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateModified { get; set; }
        /// <summary>
        /// The date the coupon was last modified, as GMT.
        /// </summary>
        [JsonProperty("date_modified_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateModifiedGMT { get; set; }
        /// <summary>
        /// Determines the type of discount that will be applied. Options: percent, fixed_cart and fixed_product. Default is fixed_cart.
        /// </summary>
        [JsonProperty("discount_type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? DiscountType { get; set; }
        /// <summary>
        /// Coupon description
        /// </summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Description { get; set; }
        /// <summary>
        /// The date the coupon expires, in the site's timezone.
        /// </summary>
        [JsonProperty("date_expires", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? DateExpires { get; set; }
        /// <summary>
        /// The date the coupon expires, as GMT.
        /// </summary>
        [JsonProperty("date_expires_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? DateExpiresGMT { get; set; }
        /// <summary>
        /// Number of times the coupon has been used already.
        /// </summary>
        [JsonProperty("usage_count", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? UsageCount { get; set; }
        /// <summary>
        /// If true, the coupon can only be used individually. Other applied coupons will be removed from the cart. Default is false.
        /// </summary>
        [JsonProperty("individual_use", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IndividualUse { get; set; }
        /// <summary>
        /// List of product IDs the coupon can be used on.
        /// </summary>
        [JsonProperty("product_ids", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<int>? ProductIds { get; set; }
        /// <summary>
        /// List of product IDs the coupon cannot be used on.
        /// </summary>
        [JsonProperty("excluded_product_ids", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<int>? ExcludedProductIds { get; set; }
        /// <summary>
        /// How many times the coupon can be used in total.
        /// </summary>
        [JsonProperty("usage_limit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? UsageLimit { get; set; }
        /// <summary>
        /// How many times the coupon can be used per customer.
        /// </summary>
        [JsonProperty("usage_limit_per_user", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? UsageLimitPerUser { get; set; }
        /// <summary>
        /// Max number of items in the cart the coupon can be applied to.
        /// </summary>
        [JsonProperty("limit_usage_to_x_items", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? LimitUsageToXItems { get; set; }
        /// <summary>
        /// If true and if the free shipping method requires a coupon, this coupon will enable free shipping. Default is false.
        /// </summary>
        [JsonProperty("free_shipping", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool FreeShipping { get; set; }
        /// <summary>
        /// List of category IDs the coupon applies to.
        /// </summary>
        [JsonProperty("product_categories", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<int>? ProductCategories { get; set; }
        /// <summary>
        /// List of category IDs the coupon does not apply to.
        /// </summary>
        [JsonProperty("excluded_product_categories", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<int>? ExcludedProductCategories { get; set; }
        /// <summary>
        /// If true, this coupon will not be applied to items that have sale prices. Default is false.
        /// </summary>
        [JsonProperty("exclude_sale_items", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ExcludeSaleItems { get; set; }
        /// <summary>
        /// Minimum order amount that needs to be in the cart before coupon applies.
        /// </summary>
        [JsonProperty("minimum_amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? MinimumAmount { get; set; }
        /// <summary>
        /// Maximum order amount allowed when using the coupon.
        /// </summary>
        [JsonProperty("maximum_amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? MaximumAmount { get; set; }
        /// <summary>
        /// List of email addresses that can use this coupon.
        /// </summary>
        [JsonProperty("email_restrictions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string>? EmailRestrictions { get; set; }
        /// <summary>
        /// List of user IDs (or guest email addresses) that have used the coupon.
        /// </summary>
        [JsonProperty("used_by", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string>? UsedBy { get; set; }
        /// <summary>
        /// Meta data.
        /// </summary>
        [JsonProperty("meta_data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<MetaData>? Metadata { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public Coupon() { }
    }
}
