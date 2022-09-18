using System;
using System.Collections.Generic;
using System.Text;
using WordPressPCL.Models;

namespace WordPressPCL.Utility
{
    /// <summary>
    /// Query products by filters (WooCommerce)
    /// </summary>
    public class ProductsQueryBuilder : QueryBuilder
    {
        /// <summary>
        /// Current page of the collection.
        /// </summary>
        /// <remarks>Default: 1</remarks>
        [QueryText("page")]
        public int? Page { get; set; }
        /// <summary>
        /// Maximum number of items to be returned in result set (1-100).
        /// </summary>
        /// <remarks>Default: 10</remarks>
        [QueryText("per_page")]
        public int? PerPage { get; set; }
        /// <summary>
        /// Limit results to those matching a string.
        /// </summary>
        [QueryText("search")]
        public string Search { get; set; }
        /// <summary>
        /// Limit response to resources published after a given ISO8601 compliant date.
        /// </summary>
        [QueryText("after")]
        public string After { get; set; }
        /// <summary>
        /// Limit response to resources published before a given ISO8601 compliant date.
        /// </summary>
        [QueryText("before")]
        public string Before { get; set; }
        /// <summary>
        /// Ensure result set excludes specific IDs.
        /// </summary>
        [QueryText("exclude")]
        public List<int> Exclude { get; set; }
        /// <summary>
        /// Limit result set to specific IDs.
        /// </summary>
        [QueryText("include")]
        public List<int> Include { get; set; }
        /// <summary>
        /// Offset the result set by a specific number of items.
        /// </summary>
        [QueryText("offset")]
        public int? Offset { get; set; }
        /// <summary>
        /// Sort collection by object attribute.
        /// </summary>
        /// <remarks>Default: date
        /// One of: date, id, include, title, slug, price, popularity and rating</remarks>
        [QueryText("orderby")]
        public ProductsOrderBy? OrderBy { get; set; }
        /// <summary>
        /// Limit result set to those of particular parent IDs.
        /// </summary>
        [QueryText("parent")]
        public List<int> Parent { get; set; }
        /// <summary>
        /// Limit result set to all items except those of a particular parent ID.
        /// </summary>
        [QueryText("parent_exclude")]
        public List<int> ParentExclude { get; set; }
        /// <summary>
        /// Limit result set to products with a specific slug.
        /// </summary>
        [QueryText("slug")]
        public string Slug { get; set; }
        /// <summary>
        /// Limit result set to products assigned a specific status. Options: any, draft, pending, private and publish
        /// </summary>
        /// <remarks>Default: any</remarks>
        [QueryText("status")]
        public ProductStatus? Status { get; set; }
        /// <summary>
        /// Limit result set to products assigned a specific type. Options: simple, grouped, external and variable.
        /// </summary>
        [QueryText("type")]
        public ProductType? Type { get; set; }
        /// <summary>
        /// Limit result set to products with a specific SKU.
        /// </summary>
        [QueryText("sku")]
        public string SKU { get; set; }
        /// <summary>
        /// Limit result set to featured products.
        /// </summary>
        [QueryText("featured")]
        public bool Featured { get; set; }
        /// <summary>
        /// Limit result set to products assigned a specific category ID.
        /// </summary>
        [QueryText("category")]
        public string Category { get; set; }
        /// <summary>
        /// Limit result set to products assigned a specific tag ID.
        /// </summary>
        [QueryText("tag")]
        public string Tag { get; set; }
        /// <summary>
        /// Limit result set to products assigned a specific shipping class ID.
        /// </summary>
        [QueryText("shipping_class")]
        public string ShippingClass { get; set; }
        /// <summary>
        /// Limit result set to products with a specific attribute.
        /// </summary>
        [QueryText("attribute")]
        public string Attribute { get; set; }
        /// <summary>
        /// Limit result set to products with a specific attribute term ID (required an assigned attribute).
        /// </summary>
        [QueryText("attribute_term")]
        public string AttributeTerm { get; set; }
        /// <summary>
        /// Limit result set to products with a specific tax class. Default options: standard, reduced-rate and zero-rate.
        /// </summary>
        [QueryText("tax_class")]
        public string TaxClass { get; set; }
        /// <summary>
        /// Limit result set to products on sale.
        /// </summary>
        [QueryText("on_sale")]
        public bool OnSale { get; set; }
        /// <summary>
        /// Limit result set to products based on a minimum price.
        /// </summary>
        [QueryText("min_price")]
        public string MinPrice { get; set; }
        /// <summary>
        /// Limit result set to products based on a maximum price.
        /// </summary>
        [QueryText("max_price")]
        public string MaxPrice { get; set; }
        /// <summary>
        /// Limit result set to products with specified stock status. Options: instock, outofstock and onbackorder.
        /// </summary>
        [QueryText("stock_status")]
        public StockStatus? StockStatus { get; set; }
    }
}
