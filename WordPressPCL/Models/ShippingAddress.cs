using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordPressPCL.Models
{
    /// <summary>
    /// WooCommerce Customer Shipping Address
    /// </summary>
    public class ShippingAddress
    {
        /// <summary>
        /// First name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        /// <summary>
        /// Last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        /// <summary>
        /// Company name.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }
        /// <summary>
        /// Address line 1
        /// </summary>
        [JsonProperty("address_1")]
        public string Address1 { get; set; }
        /// <summary>
        /// Address line 2
        /// </summary>
        [JsonProperty("address_2")]
        public string Address2 { get; set; }
        /// <summary>
        /// City name.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        /// ISO code or name of the state, province or district.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
        /// <summary>
        /// Postal code.
        /// </summary>
        [JsonProperty("postcode")]
        public string PostCode { get; set; }
        /// <summary>
        /// ISO code of the country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
