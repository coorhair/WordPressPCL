using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WordPressPCL.Utility
{
    /// <summary>
    /// Class support OAuth1 authentication
    /// </summary>
    public static class OAuth1Authenticator
    {
        /// <summary>
        /// The set of characters that are unreserved in RFC 2396 but are NOT unreserved in RFC 3986.
        /// </summary>
        private static readonly string[] UriRfc3986CharsToEscape = new[] { "!", "*", "'", "(", ")" };

        /// <summary>
        /// Escapes a string according to the URI data string rules given in RFC 3986.
        /// </summary>
        /// <param name="value">The value to escape.</param>
        /// <returns>The escaped value.</returns>
        /// <remarks>
        /// The <see cref="Uri.EscapeDataString"/> method is <i>supposed</i> to take on
        /// RFC 3986 behavior if certain elements are present in a .config file.  Even if this
        /// actually worked (which in my experiments it <i>doesn't</i>), we can't rely on every
        /// host actually having this configuration element present.
        /// </remarks>
        internal static string EscapeUriDataStringRfc3986(string? value)
        {
            // Start with RFC 2396 escaping by calling the .NET method to do the work.
            // This MAY sometimes exhibit RFC 3986 behavior (according to the documentation).
            // If it does, the escaping we do that follows it will be a no-op since the
            // characters we search for to replace can't possibly exist in the string.
            StringBuilder escaped = new(Uri.EscapeDataString(value));

            // Upgrade the escaping to RFC 3986, if necessary.
            for (int i = 0; i < UriRfc3986CharsToEscape.Length; i++)
            {
                escaped.Replace(UriRfc3986CharsToEscape[i], Uri.HexEscape(UriRfc3986CharsToEscape[i][0]));
            }

            // Return the fully-RFC3986-escaped string.
            return escaped.ToString();
        }
        
        /// <summary>
        /// Build OAuth 1.0 signature and more
        /// </summary>
        /// <param name="url">endpoint</param>
        /// <param name="httpMethod">http method like GET/POST/PUT</param>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        /// <param name="tokenSecret"></param>
        /// <param name="tokenValue"></param>
        /// <returns></returns>
        public static Dictionary<string, string> Build(string url, string httpMethod, string? consumerKey, string? consumerSecret, string? tokenSecret = null, string? tokenValue = null) 
        {
            var timeStamp = ((int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString();
            var nonce = Convert.ToBase64String(Encoding.UTF8.GetBytes(timeStamp));
            var oauth_consumer_key = EscapeUriDataStringRfc3986(consumerKey);
            var oauth_nonce = EscapeUriDataStringRfc3986(nonce);
            var oauth_signature_method = EscapeUriDataStringRfc3986("HMAC-SHA1");
            var oauth_timestamp = EscapeUriDataStringRfc3986(timeStamp);
            var oauth_token = EscapeUriDataStringRfc3986(tokenValue != null ? tokenValue : "");
            var oauth_version = EscapeUriDataStringRfc3986("1.0");
            var signatureBase = new StringBuilder(nameof(oauth_consumer_key)).Append('=').Append(oauth_consumer_key).Append('&')
                .Append(nameof(oauth_nonce)).Append('=').Append(oauth_nonce).Append('&')
                .Append(nameof(oauth_signature_method)).Append('=').Append(oauth_signature_method).Append('&')
                .Append(nameof(oauth_timestamp)).Append('=').Append(oauth_timestamp).Append('&')
                .Append(nameof(oauth_token)).Append('=').Append(oauth_token).Append('&')
                .Append(nameof(oauth_version)).Append('=').Append(oauth_version).ToString();
            signatureBase = new StringBuilder(EscapeUriDataStringRfc3986(httpMethod.ToUpper())).Append('&')
                .Append(EscapeUriDataStringRfc3986(url.ToLower())).Append('&')
                .Append(EscapeUriDataStringRfc3986(signatureBase)).ToString();
            var key = new StringBuilder(EscapeUriDataStringRfc3986(consumerSecret)).Append('&').Append(EscapeUriDataStringRfc3986(tokenSecret != null ? tokenSecret : "")).ToString();
            var signatureEncoding = new ASCIIEncoding();
            var keyBytes = signatureEncoding.GetBytes(key);
            var signatureBaseBytes = signatureEncoding.GetBytes(signatureBase);
            string oauth_signature;
            using (var hmacsha1 = new HMACSHA1(keyBytes))
            {
                var hashBytes = hmacsha1.ComputeHash(signatureBaseBytes);
                oauth_signature = Convert.ToBase64String(hashBytes);
            }
            oauth_signature = EscapeUriDataStringRfc3986(oauth_signature);
            return new Dictionary<string, string>()
            {
                { nameof(oauth_consumer_key), oauth_consumer_key },
                { nameof(oauth_nonce), oauth_nonce },
                { nameof(oauth_signature_method), oauth_signature_method },
                { nameof(oauth_timestamp), oauth_timestamp },
                { nameof(oauth_token), oauth_token },
                { nameof(oauth_version), oauth_version },
                { nameof(oauth_signature), oauth_signature },
            };
        }

        /// <summary>
        /// Build Oauth 1.0 route
        /// </summary>
        /// <param name="url"></param>
        /// <param name="httpMethod"></param>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        /// <param name="tokenSecret"></param>
        /// <param name="tokenValue"></param>
        /// <returns></returns>
        public static string BuildRoute(string url, string httpMethod, string? consumerKey, string? consumerSecret, string? tokenSecret = null, string? tokenValue = null)
        {
            var timeStamp = ((int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString();
            var nonce = Convert.ToBase64String(Encoding.UTF8.GetBytes(timeStamp));
            var oauth_consumer_key = consumerKey;
            var oauth_nonce = nonce.Replace("=", "");
            var oauth_signature_method = "HMAC-SHA1";
            var oauth_timestamp = timeStamp;
            var oauth_token = tokenValue ?? "";
            var oauth_version = "1.0";
            UriBuilder tokenRequestBuilder = new(url);
            var query = HttpUtility.ParseQueryString(tokenRequestBuilder.Query);
            query[nameof(oauth_consumer_key)] = oauth_consumer_key;
            query[nameof(oauth_nonce)] = oauth_nonce;
            query[nameof(oauth_signature_method)] = oauth_signature_method;
            query[nameof(oauth_timestamp)] = oauth_timestamp;
            query[nameof(oauth_version)] = oauth_version;
            if (!string.IsNullOrEmpty(oauth_token)) query[nameof(oauth_token)] = oauth_token;
            var signatureBase = $"{httpMethod.ToUpper()}&{Uri.EscapeDataString(url)}&{Uri.EscapeDataString(query.ToString())}";
            string oauth_signature;
            using (var hmacsha1 = new HMACSHA1(Encoding.ASCII.GetBytes($"{consumerSecret}&{tokenSecret ?? ""}")))
            {
                var hashBytes = hmacsha1.ComputeHash(Encoding.ASCII.GetBytes(signatureBase));
                oauth_signature = Convert.ToBase64String(hashBytes);
            }
            query[nameof(oauth_signature)] = oauth_signature;
            tokenRequestBuilder.Query = query.ToString();
            var route = tokenRequestBuilder.ToString();
            return route;
        }

        /// <summary>
        /// Build OAuth 1.0 ready for query
        /// </summary>
        /// <param name="url">endpoint</param>
        /// <param name="httpMethod">http method like GET/POST/PUT</param>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        /// <param name="tokenSecret"></param>
        /// <param name="tokenValue"></param>
        /// <returns></returns>
        public static string GenQueryParams(string url, string httpMethod, string? consumerKey, string? consumerSecret, string? tokenSecret = null, string? tokenValue = null)
        {
            var oauthParams = Build(url, httpMethod, consumerKey, consumerSecret, tokenSecret, tokenValue);
            List<string> qsParams = new();
            foreach (var pair in oauthParams)
            {
                if (!string.IsNullOrEmpty(pair.Value))
                {
                    qsParams.Add($"{pair.Key}={pair.Value}");
                }
            }
            return string.Join("&", qsParams);
        }
    }
}
