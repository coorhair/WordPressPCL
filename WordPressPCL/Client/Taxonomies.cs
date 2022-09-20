﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WordPressPCL.Interfaces;
using WordPressPCL.Models;
using WordPressPCL.Utility;

namespace WordPressPCL.Client
{
    /// <summary>
    /// Client class for interaction with Taxonomies endpoint WP REST API
    /// </summary>
    public class Taxonomies : IReadOperation<Taxonomy>, IQueryOperation<Taxonomy, TaxonomiesQueryBuilder>
    {
        private readonly HttpHelper _httpHelper;
        private const string _methodPath = "taxonomies";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpHelper">reference to HttpHelper class for interaction with HTTP</param>
        public Taxonomies(HttpHelper httpHelper)
        {
            _httpHelper = httpHelper;
        }
        /// <summary>
        /// Get latest
        /// </summary>
        /// <param name="embed">include embed info</param>
        /// <param name="useAuth">Send request with authentication header</param>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        /// <returns>Get latest taxonomies</returns>
        public async Task<IEnumerable<Taxonomy>> GetAsync(bool embed = false, bool useAuth = false, string? consumerKey = null, string? consumerSecret = null)
        {
            List<Taxonomy> entities = new();
            Dictionary<string, Taxonomy> entities_page = await _httpHelper.GetRequestAsync<Dictionary<string, Taxonomy>>($"{_methodPath}", embed, useAuth).ConfigureAwait(false);
            foreach (var ent in entities_page)
            {
                entities.Add(ent.Value);
            }
            return entities;
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="embed">Include embed info</param>
        /// <param name="useAuth">Send request with authentication header</param>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        /// <returns>List of all result</returns>
        public async Task<IEnumerable<Taxonomy>> GetAllAsync(bool embed = false, bool useAuth = false, string? consumerKey = null, string? consumerSecret = null)
        {
            //100 - Max posts per page in WordPress REST API, so this is hack with multiple requests
            List<Taxonomy> entities = new();
            Dictionary<string, Taxonomy> entities_page = (await _httpHelper.GetRequestAsync<Dictionary<string, Taxonomy>>($"{_methodPath}", embed, useAuth).ConfigureAwait(false));
            foreach (var ent in entities_page)
            {
                entities.Add(ent.Value);
            }
            return entities;
        }

        /// <summary>
        /// Get Entity by Id
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="embed">include embed info</param>
        /// <param name="useAuth">Send request with authentication header</param>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        /// <returns>Entity by Id</returns>
        public Task<Taxonomy> GetByIDAsync(object ID, bool embed = false, bool useAuth = false, string? consumerKey = null, string? consumerSecret = null)
        {
            return _httpHelper.GetRequestAsync<Taxonomy>($"{_methodPath}/{ID}", embed, useAuth);
        }

        /// <summary>
        /// Create a parametrized query and get a result
        /// </summary>
        /// <param name="queryBuilder">Query builder with specific parameters</param>
        /// <param name="useAuth">Send request with authentication header</param>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        /// <returns>List of filtered result</returns>
        public async Task<IEnumerable<Taxonomy>> QueryAsync(TaxonomiesQueryBuilder queryBuilder, bool useAuth = false, string? consumerKey = null, string? consumerSecret = null)
        {
            List<Taxonomy> entities = new();
            var entities_dict = await _httpHelper.GetRequestAsync<Dictionary<string, Taxonomy>>($"{_methodPath}{queryBuilder.BuildQuery()}", false, useAuth).ConfigureAwait(false);
            foreach (var ent in entities_dict)
            {
                entities.Add(ent.Value);
            }
            return entities;
        }
    }
}