using System;
using System.Collections.Generic;
using System.Text;
using WordPressPCL.Models;

namespace WordPressPCL.Utility
{
    /// <summary>
    /// Query customers by filters (WooCommerce)
    /// </summary>
    public class CustomersQueryBuilder : QueryBuilder
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
        /// Offset the result set by a specific number of items.
        /// </summary>
        [QueryText("offset")]
        public int? Offset { get; set; }
        /// <summary>
        /// Sort collection by object attribute. Options: id, include, name and registered_date. 
        /// </summary>
        /// <remarks>Default is name.</remarks>
        [QueryText("orderby")]
        public UsersOrderBy? OrderBy { get; set; }
        /// <summary>
        /// Limit result set to resources with a specific email.
        /// </summary>
        [QueryText("email")]
        public string Email { get; set; }

        /// <summary>
        /// Limit result set to resources with a specific role. Options: all, administrator, editor, author, contributor, subscriber, customer and shop_manager. 
        /// </summary>
        /// <remarks>Default is customer.</remarks>
        [QueryText("role")]
        public CustomerRole? Role { get; set; }
    }
}
