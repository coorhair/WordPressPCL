using System;
using System.Collections.Generic;
using System.Text;
using WordPressPCL.Models;

namespace WordPressPCL.Utility
{
    /// <summary>
    /// Query product categories by filters (WooCommerce)
    /// </summary>
    public class ProductCategoriesQueryBuilder : QueryBuilder
    {
        /// <summary>
        /// Current page of the collection. 
        /// </summary>
        /// <remarks>Default is 1</remarks>
        [QueryText("page")]
        public int? Page { get; set; }
        /// <summary>
        /// Maximum number of items to be returned in result set. 
        /// </summary>
        /// <remarks>Default is 10</remarks>
        [QueryText("per_page")]
        public int? PerPage { get; set; }
        /// <summary>
        /// Limit results to those matching a string.
        /// </summary>
        [QueryText("search")]
        public string Search { get; set; }
        /// <summary>
        /// Ensure result set excludes specific ids.
        /// </summary>
        [QueryText("exclude")]
        public List<int> Exclude { get; set; }
        /// <summary>
        /// Ensure result set excludes specific ids.
        /// </summary>
        [QueryText("include")]
        public List<int> Include { get; set; }
        /// <summary>
        /// Sort collection by resource attribute. Options: id, include, name, slug, term_group, description and count. 
        /// </summary>
        /// <remarks>Default is name</remarks>
        [QueryText("orderby")]
        public TermsOrderBy? OrderBy { get; set; }
        /// <summary>
        /// Whether to hide resources not assigned to any products. 
        /// </summary>
        /// <remarks>Default is false</remarks>
        [QueryText("hide_empty")]
        public bool HideEmpty { get; set; }
        /// <summary>
        /// Limit result set to resources assigned to a specific parent.
        /// </summary>
        [QueryText("parent")]
        public int? Parent { get; set; }
        /// <summary>
        /// Limit result set to resources assigned to a specific product.
        /// </summary>
        [QueryText("product")]
        public int? Product { get; set; }
        /// <summary>
        /// Limit result set to resources with a specific slug.
        /// </summary>
        [QueryText("slug")]
        public string Slug { get; set; }
    }
}
