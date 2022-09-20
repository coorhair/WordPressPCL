using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Product Variation
    /// </summary>
    public class ProductVariation : Base
    {

        /// <summary>
        /// Variation URL
        /// </summary>
        [JsonProperty("permalink", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? PermanentLink { get; set; }
        /// <summary>
        /// The date the product was created, in the site's timezone
        /// </summary>
        [JsonProperty("date_created", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// The date the product was created, as GMT.
        /// </summary>
        [JsonProperty("date_created_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateCreatedGMT { get; set; }
        /// <summary>
        /// The date the product was last modified, in the site's timezone
        /// </summary>
        [JsonProperty("date_modified", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateModified { get; set; }
        /// <summary>
        /// The date the product was last modified, as GMT
        /// </summary>
        [JsonProperty("date_modified_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateModifiedGMT { get; set; }
        /// <summary>
        /// Product status (post status). Options: draft, pending, private and publish. Default is publish
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Status { get; set; }
        /// <summary>
        /// Product description.
        /// </summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Description { get; set; }
        /// <summary>
        /// Unique identifier
        /// </summary>
        [JsonProperty("sku", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? SKU { get; set; }
        /// <summary>
        /// Current product price.
        /// </summary>
        [JsonProperty("price", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Price { get; set; }
        /// <summary>
        /// Product regular price.
        /// </summary>
        [JsonProperty("regular_price", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? RegularPrice { get; set; }
        /// <summary>
        /// Product sale price.
        /// </summary>
        [JsonProperty("sale_price", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? SalePrice { get; set; }
        /// <summary>
        /// Start date of sale price, in the site's timezone.
        /// </summary>
        [JsonProperty("date_on_sale_from", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? DateOnSaleFrom { get; set; }
        /// <summary>
        /// Start date of sale price, as GMT.
        /// </summary>
        [JsonProperty("date_on_sale_from_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? DateOnSaleFromGMT { get; set; }
        /// <summary>
        /// End date of sale price, in the site's timezone.
        /// </summary>
        [JsonProperty("date_on_sale_to", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? DateOnSaleTo { get; set; }
        /// <summary>
        /// End date of sale price, as GMT.
        /// </summary>
        [JsonProperty("date_on_sale_to_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? DateOnSaleToGMT { get; set; }
        /// <summary>
        /// Shows if the product is on sale.
        /// </summary>
        [JsonProperty("on_sale", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool OnSale { get; set; }
        /// <summary>
        /// Shows if the product can be bought.
        /// </summary>
        [JsonProperty("purchasable", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Purchasable { get; set; }
        /// <summary>
        /// If the product is virtual. Default is false
        /// </summary>
        [JsonProperty("virtual", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsVirtual { get; set; }
        /// <summary>
        /// If the product is downloadable. Default is false.
        /// </summary>
        [JsonProperty("downloadable", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DownLoadable { get; set; }
        /// <summary>
        /// List of downloadable files.
        /// </summary>
        [JsonProperty("downloads", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Download>? Downloads { get; set; }
        /// <summary>
        /// Number of times downloadable files can be downloaded after purchase. Default is -1
        /// </summary>
        [JsonProperty("download_limit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? DownloadLimit { get; set; }
        /// <summary>
        /// Number of days until access to downloadable files expires. Default is -1.
        /// </summary>
        [JsonProperty("download_expiry", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? DownloadExpiry { get; set; }
        /// <summary>
        /// Tax status. Options: taxable, shipping and none. Default is taxable.
        /// </summary>
        [JsonProperty("tax_status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? TaxStatus { get; set; }
        /// <summary>
        /// Tax class.
        /// </summary>
        [JsonProperty("tax_class", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? TaxClass { get; set; }
        /// <summary>
        /// Stock management at product level. Default is false.
        /// </summary>
        [JsonProperty("manage_stock", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ManageStock { get; set; }
        /// <summary>
        /// Stock quantity.
        /// </summary>
        [JsonProperty("stock_quantity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? StockQuantity { get; set; }
        /// <summary>
        /// Controls the stock status of the product. Options: instock, outofstock, onbackorder. Default is instock.
        /// </summary>
        [JsonProperty("stock_status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? StockStatus { get; set; }
        /// <summary>
        /// If managing stock, this controls if backorders are allowed. Options: no, notify and yes. Default is no.
        /// </summary>
        [JsonProperty("backorders", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? BackOrders { get; set; }
        /// <summary>
        /// Shows if backorders are allowed.
        /// </summary>
        [JsonProperty("backorders_allowed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool BackOrdersAllowed { get; set; }
        /// <summary>
        /// Shows if the product is on backordered.
        /// </summary>
        [JsonProperty("backordered", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool BackOrdered { get; set; }
        /// <summary>
        /// Product weight.
        /// </summary>
        [JsonProperty("weight", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Weight { get; set; }
        /// <summary>
        /// Product dimensions
        /// </summary>
        [JsonProperty("dimensions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Dimension? Dimensions { get; set; }
        /// <summary>
        /// Shipping class slug.
        /// </summary>
        [JsonProperty("shipping_class", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? ShippingClass { get; set; }
        /// <summary>
        /// Shipping class ID.
        /// </summary>
        [JsonProperty("shipping_class_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ShippingClassId { get; set; }
        /// <summary>
        /// Variation image data
        /// </summary>
        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Image? Image { get; set; }
        /// <summary>
        /// List of attributes. 
        /// </summary>
        [JsonProperty("attributes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<ProductAttribute>? Attributes { get; set; }
        /// <summary>
        /// Menu order, used to custom sort products
        /// </summary>
        [JsonProperty("menu_order", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? MenuOrder { get; set; }
        /// <summary>
        /// Meta data
        /// </summary>
        [JsonProperty("meta_data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<MetaData>? Metadata { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ProductVariation() { }
    }
}
