using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Helper
{
    /// <summary>
    /// Static class that provides access to HttpCLient
    /// </summary>
    public static class ApiHelper
    {
        /// <summary>
        /// Static instance of HttpClient
        /// </summary>
        public static HttpClient ApiClient { get; set; }

        /// <summary>
        /// Initializes HttpClient
        /// </summary>
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

      
    }
}
