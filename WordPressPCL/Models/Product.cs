using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Product
    /// </summary>
    public class Product : ProductVariation
    {
        /// <summary>
        /// Product name.
        /// </summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>
        /// Product slug.
        /// </summary>
        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Slug { get; set; }
        /// <summary>
        /// Product type. Options: simple, grouped, external and variable. Default is simple.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        /// <summary>
        /// Featured product. Default is false.
        /// </summary>
        [JsonProperty("featured", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Featured { get; set; }
        /// <summary>
        /// Catalog visibility. Options: visible, catalog, search and hidden. Default is visible.
        /// </summary>
        [JsonProperty("catalog_visibility", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CatalogVisibility { get; set; }
        /// <summary>
        /// Product short description.
        /// </summary>
        [JsonProperty("short_description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ShortDescription { get; set; }
        /// <summary>
        /// Price formatted in HTML.
        /// </summary>
        [JsonProperty("price_html", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PriceHtml { get; set; }
        /// <summary>
        /// Amount of sales
        /// </summary>
        [JsonProperty("total_sales", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? TotalSales { get; set; }
        /// <summary>
        /// Product external URL. Only for external products.
        /// </summary>
        [JsonProperty("external_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExternalUrl { get; set; }
        /// <summary>
        /// Product external button text. Only for external products.
        /// </summary>
        [JsonProperty("button_text", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ButtonText { get; set; }
        /// <summary>
        /// Allow one item to be bought in a single order. Default is false.
        /// </summary>
        [JsonProperty("sold_individually", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SoldIndividually { get; set; }
        /// <summary>
        /// Shows if the product need to be shipped.
        /// </summary>
        [JsonProperty("shipping_required", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ShippingRequired { get; set; }
        /// <summary>
        /// Shows whether or not the product shipping is taxable.
        /// </summary>
        [JsonProperty("shipping_taxable", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ShippingTaxable { get; set; }
        /// <summary>
        /// Allow reviews. Default is true.
        /// </summary>
        [JsonProperty("reviews_allowed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ReviewsAllowed { get; set; }
        /// <summary>
        /// Reviews average rating
        /// </summary>
        [JsonProperty("average_rating", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AverageRating { get; set; }
        /// <summary>
        /// Amount of reviews that the product have.
        /// </summary>
        [JsonProperty("rating_count", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? RatingCount { get; set; }
        /// <summary>
        /// List of related products IDs.
        /// </summary>
        [JsonProperty("related_ids", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<int> RelatedIds { get; set; }
        /// <summary>
        /// List of up-sell products IDs.
        /// </summary>
        [JsonProperty("upsell_ids", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<int> UpSellIds { get; set; }
        /// <summary>
        /// List of cross-sell products IDs.
        /// </summary>
        [JsonProperty("cross_sell_ids", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<int> CrossSellIds { get; set; }
        /// <summary>
        /// Product parent ID.
        /// </summary>
        [JsonProperty("parent_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ParentId { get; set; }
        /// <summary>
        /// Optional note to send the customer after purchase.
        /// </summary>
        [JsonProperty("purchase_note", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PurchaseNote { get; set; }
        /// <summary>
        /// List of categories. 
        /// </summary>
        [JsonProperty("categories", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Category> Categories { get; set; }
        /// <summary>
        /// List of tags. 
        /// </summary>
        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<ProductTag> Tags { get; set; }
        /// <summary>
        /// List of images. 
        /// </summary>
        [JsonProperty("images", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Image> Images { get; set; }
        
        /** hide this field from super class */
        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Ignore)]
        private Image? Image { get; set; }
        
        /// <summary>
        /// Defaults variation attributes 
        /// </summary>
        [JsonProperty("default_attributes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<DefaultAttribute> DefaultAttributes { get; set; }
        /// <summary>
        /// List of variations IDs.
        /// </summary>
        [JsonProperty("variations", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<int> Variations { get; set; }
        /// <summary>
        /// List of grouped products ID.
        /// </summary>
        [JsonProperty("grouped_products", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<int> GroupedProducts { get; set; }
        
        public Product() : base() { }
    }
}
