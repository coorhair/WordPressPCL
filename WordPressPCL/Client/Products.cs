using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using WordPressPCL.Interfaces;
using WordPressPCL.Utility;
using WordPressPCL.Models;

namespace WordPressPCL.Client
{
    /// <summary>
    /// Implement client to query WooCommerce products
    /// </summary>
    public class Products : CRUDOperation<Product, ProductsQueryBuilder>, ICountOperation
    {
        #region Init
        private const string _productPath = "wc/v3/products";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpHelper">reference to HttpHelper class for interaction with HTTP</param>
        public Products(HttpHelper httpHelper) : base(httpHelper, _productPath, ignoreDefaultPath: true)
        {
        }

        #endregion Init

        #region Custom

        /// <summary>
        /// List products by filter conditions
        /// </summary>
        /// <param name="filter">conditions to filter return products</param>
        /// <param name="useAuth">Send request with authentication header</param>
        /// <returns>List of products</returns>
        public Task<IEnumerable<Product>?> ListProductsAsync(ProductsQueryBuilder filter, bool useAuth = true)
        {
            return QueryAsync(filter, useAuth);
        }

        /// <summary>
        /// Create new product
        /// </summary>
        /// <param name="entity">product for creating</param>
        /// <returns>product detail</returns>
        public Task<Product?> CreateProductAsync(Product entity)
        {
            return CreateAsync(entity);
        }

        /// <summary>
        /// Get product detail
        /// </summary>
        /// <param name="productId">product ID</param>
        /// <param name="useAuth">send request with authentication header</param>
        /// <returns>product detail</returns>
        public Task<Product?> GetProductAsync(object productId, bool useAuth = true)
        {
            return GetByIDAsync(productId, false, useAuth);
        }

        /// <summary>
        /// Update product data
        /// </summary>
        /// <param name="entity">product for updating</param>
        /// <returns>product detail</returns>
        public Task<Product?> UpdateProductAsync(Product entity)
        {
            return Update2Async(entity);
        }

        /// <summary>
        /// Delete product
        /// </summary>
        /// <param name="productId">product for deleting</param>
        /// <param name="force">Use true whether to permanently delete the product, Default is false.</param>
        /// <returns>deleting failure or success</returns>
        public Task<bool> DeleteProductAsync(object productId, bool force = false)
        {
            return HttpHelper.DeleteRequestAsync($"{MethodPath}/{productId}".SetQueryParam(nameof(force), force.ToString().ToLower(CultureInfo.InvariantCulture)), 
                ignoreDefaultPath: IgnoreDefaultPath);
        }

        /// <summary>
        /// Count total products
        /// </summary>
        /// <returns></returns>
        public async Task<int> GetCountAsync()
        {
            var responseHeaders = await HttpHelper.HeadRequestAsync(MethodPath, true, IgnoreDefaultPath).ConfigureAwait(false);
            var totalHeaderVal = responseHeaders.GetValues("X-WP-Total").First();
            return int.Parse(totalHeaderVal, CultureInfo.InvariantCulture);
        }

        #endregion Custom
    }
}
