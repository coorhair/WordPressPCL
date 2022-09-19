using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressPCL.Interfaces;
using WordPressPCL.Models;
using WordPressPCL.Utility;

namespace WordPressPCL.Client
{
    /// <summary>
    /// Implement client to query WooCommerce products
    /// </summary>
    public class ProductCategories : CRUDOperation<ProductCategory, ProductCategoriesQueryBuilder>, ICountOperation
    {
        #region Init

        private const string _categoryPath = "wc/v3/products/categories";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpHelper">reference to HttpHelper class for interaction with HTTP</param>
        public ProductCategories(HttpHelper httpHelper) : base(httpHelper, _categoryPath, ignoreDefaultPath: true)
        {
        }

        #endregion

        #region Custom

        /// <summary>
        /// List categories of products by filter conditions
        /// </summary>
        /// <param name="filter">conditions to filter return categories</param>
        /// <param name="useAuth">Send request with authentication header</param>
        /// <returns>List of products</returns>
        public Task<IEnumerable<ProductCategory>> ListCategoriesAsync(ProductCategoriesQueryBuilder filter, bool useAuth = true)
        {
            return QueryAsync(filter, useAuth);
        }

        /// <summary>
        /// Create new product's category
        /// </summary>
        /// <param name="entity">category for creating</param>
        /// <returns>category detail</returns>
        public Task<ProductCategory> CreateCategoryAsync(ProductCategory entity)
        {
            return CreateAsync(entity);
        }

        /// <summary>
        /// Get product's category detail
        /// </summary>
        /// <param name="categoryId">category ID</param>
        /// <param name="useAuth">send request with authentication header</param>
        /// <returns>product detail</returns>
        public Task<ProductCategory> GetCategoryAsync(object categoryId, bool useAuth = true)
        {
            return GetByIDAsync(categoryId, false, useAuth);
        }

        /// <summary>
        /// Update product's category data
        /// </summary>
        /// <param name="entity">category for updating</param>
        /// <returns>category detail</returns>
        public Task<ProductCategory> UpdateCategoryAsync(ProductCategory entity)
        {
            return Update2Async(entity);
        }

        /// <summary>
        /// Delete product's category
        /// </summary>
        /// <param name="categoryId">category for deleting</param>
        /// <param name="force">Required to be true, as resource does not support trashing.</param>
        /// <returns>deleting failure or success</returns>
        public Task<bool> DeleteCategoryAsync(object categoryId, bool force = false)
        {
            return HttpHelper.DeleteRequestAsync($"{MethodPath}/{categoryId}".SetQueryParam(nameof(force), force.ToString().ToLower(CultureInfo.InvariantCulture)),
                ignoreDefaultPath: IgnoreDefaultPath);
        }

        /// <summary>
        /// Count total product categories
        /// </summary>
        /// <returns></returns>
        public async Task<int> GetCountAsync()
        {
            var responseHeaders = await HttpHelper.HeadRequestAsync(MethodPath, true, IgnoreDefaultPath).ConfigureAwait(false);
            var totalHeaderVal = responseHeaders.GetValues("X-WP-Total").First();
            return int.Parse(totalHeaderVal, CultureInfo.InvariantCulture);
        }

        #endregion
    }
}
