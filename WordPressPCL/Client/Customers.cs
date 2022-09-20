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
    /// Implement client to query WooCommerce customers
    /// </summary>
    public class Customers : CRUDOperation<Customer, CustomersQueryBuilder>, ICountOperation
    {
        #region Init

        private const string _customerPath = "wc/v3/customers";
        private readonly string _consumerKey;
        private readonly string _consumerSecret;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpHelper">reference to HttpHelper class for interaction with HTTP</param>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        public Customers(HttpHelper httpHelper, string consumerKey, string consumerSecret) : base(httpHelper, _customerPath, ignoreDefaultPath: true)
        {
            _consumerKey = consumerKey;
            _consumerSecret = consumerSecret;
        }

        #endregion

        #region Custom

        /// <summary>
        /// List customers by filter conditions
        /// </summary>
        /// <param name="filter">conditions to filter return customers</param>
        /// <param name="useAuth">Send request with authentication header</param>
        /// <returns>List of products</returns>
        public Task<IEnumerable<Customer>?> ListCustomersAsync(CustomersQueryBuilder filter, bool useAuth = true)
        {
            return QueryAsync(filter, useAuth, _consumerKey, _consumerSecret);
        }

        /// <summary>
        /// Create new customer
        /// </summary>
        /// <param name="entity">customer for creating</param>
        /// <returns>customer detail</returns>
        public Task<Customer?> CreateCustomerAsync(Customer entity)
        {
            return CreateAsync(entity, _consumerKey, _consumerSecret);
        }

        /// <summary>
        /// Get customer detail
        /// </summary>
        /// <param name="customerId">customer ID</param>
        /// <param name="useAuth">send request with authentication header</param>
        /// <returns>customer detail</returns>
        public Task<Customer?> GetCustomerAsync(object customerId, bool useAuth = true)
        {
            return GetByIDAsync(customerId, false, useAuth, _consumerKey, _consumerSecret);
        }

        /// <summary>
        /// Update customer data
        /// </summary>
        /// <param name="entity">customer for updating</param>
        /// <returns>customer detail</returns>
        public Task<Customer?> UpdateCustomerAsync(Customer entity)
        {
            return Update2Async(entity, _consumerKey, _consumerSecret);
        }

        /// <summary>
        /// Delete a customer
        /// </summary>
        /// <param name="customerId">customer for deleting</param>
        /// <param name="force">Required to be true, as resource does not support trashing.</param>
        /// <param name="reassign">User ID to reassign posts to.</param>
        /// <returns>deleting failure or success</returns>
        public Task<bool> DeleteCustomerAsync(object customerId, bool force = false, int? reassign = null)
        {
            var route = $"{MethodPath}/{customerId}";
            route = route.SetQueryParam(nameof(force), force.ToString().ToLower(CultureInfo.InvariantCulture));
            if (reassign != null) route = route.SetQueryParam(nameof(reassign), reassign.ToString());
            if (!string.IsNullOrEmpty(_consumerKey) && !string.IsNullOrEmpty(_consumerSecret))
            {
                //route = $"{route}?{OAuth1Authenticator.GenQueryParams(route, "DELETE", _consumerKey, _consumerSecret)}";
                route = OAuth1Authenticator.BuildRoute($"{HttpHelper.GetBaseAddress(IgnoreDefaultPath)}{route}", "DELETE", _consumerKey, _consumerSecret);
            }
            return HttpHelper.DeleteRequestAsync(route, ignoreDefaultPath: IgnoreDefaultPath);
        }

        /// <summary>
        /// Count total customers
        /// </summary>
        /// <returns></returns>
        public async Task<int> GetCountAsync()
        {
            var route = MethodPath;
            if (!string.IsNullOrEmpty(_consumerKey) && !string.IsNullOrEmpty(_consumerSecret))
            {
                //route = $"{route}?{OAuth1Authenticator.GenQueryParams(route, "HEAD", _consumerKey, _consumerSecret)}";
                route = OAuth1Authenticator.BuildRoute($"{HttpHelper.GetBaseAddress(IgnoreDefaultPath)}{route}", "HEAD", _consumerKey, _consumerSecret);
            }
            var responseHeaders = await HttpHelper.HeadRequestAsync(route, true, IgnoreDefaultPath).ConfigureAwait(false);
            var totalHeaderVal = responseHeaders.GetValues("X-WP-Total").First();
            return int.Parse(totalHeaderVal, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Retrieve customer downloads permissions.
        /// </summary>
        /// <param name="customerId">customer for retreive all his downloads</param>
        /// <returns></returns>
        public async Task<IEnumerable<CustomerDownload>?> ListCustomerDownloadsAsync(object customerId)
        {
            var route = $"{MethodPath}/{customerId}/downloads";
            if (!string.IsNullOrEmpty(_consumerKey) && !string.IsNullOrEmpty(_consumerSecret))
            {
                //route = $"{route}?{OAuth1Authenticator.GenQueryParams(route, "GET", _consumerKey, _consumerSecret)}";
                route = OAuth1Authenticator.BuildRoute($"{HttpHelper.GetBaseAddress(IgnoreDefaultPath)}{route}", "GET", _consumerKey, _consumerSecret);
            }
            return await HttpHelper.GetRequestAsync<IEnumerable<CustomerDownload>>(route, false, true, true);
        }

        #endregion
    }
}
