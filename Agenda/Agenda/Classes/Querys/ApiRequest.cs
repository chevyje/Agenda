using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Agenda.Classes.Querys
{
    internal static class ApiRequest
    {
        public static string GetRequest(string endpoint, string[] queryParams = null, string id = null)
        {
            // Check if token is there and not expired, if not valid request a new token.
            if (string.IsNullOrEmpty(SessionApi.SessionToken) || DateTime.Now >= SessionApi.expiration) { SessionApi.GetSession(); }
            var client = new HttpClient();

            // Add headers
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + SessionApi.SessionToken);

            // Format Url
            var url = "https://api.e-boekhouden.nl/v1" + endpoint;
            if (!string.IsNullOrEmpty(id) && queryParams == null)
            {
                url += "/" + id;
            }
            if (queryParams != null && queryParams.Length > 0)
            {
                var query = string.Join("&", queryParams);
                url += "?" + query;
            }

            // Make request
            var response = client.GetAsync(url).Result;

            // Only continue if request is successful.
            if (!response.IsSuccessStatusCode) return "Get request failed";

            // Read response
            var responseBody = response.Content.ReadAsStringAsync().Result;
            return responseBody;
        }

        public static string PostRequest(string endpoint, object data)
        {
            // Check if token is there and not expired, if not valid request a new token.
            if (string.IsNullOrEmpty(SessionApi.sessionToken) || DateTime.Now >= SessionApi.expiration) { SessionApi.GetSession(); }
            var client = new HttpClient();

            // Add headers
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + SessionApi.sessionToken);

            // Format Url
            var url = "https://api.e-boekhouden.nl/v1" + endpoint;

            // Format data
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Make Request
            var response = client.PostAsync(url, content).Result;

            // Only continue if request is successful
            if (!response.IsSuccessStatusCode) return "Post request failed";

            // Read response
            var responseBody = response.Content.ReadAsStringAsync().Result;
            return responseBody;
        }

        public static string PatchRequest(string endpoint, object data, string id)
        {
            // Check if token is there and not expired, if not valid request a new token.
            if (string.IsNullOrEmpty(SessionApi.sessionToken) || DateTime.Now >= SessionApi.expiration) { SessionApi.GetSession(); }
            var client = new HttpClient();

            // Add headers
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + SessionApi.sessionToken);

            // Format Url
            var url = "https://api.e-boekhouden.nl/v1" + endpoint;
            if (!string.IsNullOrEmpty(id)) { url += "/" + id; }
            else { return "Patch request failed"; }

            // Format data
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Make Request
            var response = client.PostAsync(url, content).Result;

            // Only continue if request is successful
            if (!response.IsSuccessStatusCode) return "Patch request failed";

            // Read response
            var responseBody = response.Content.ReadAsStringAsync().Result;
            return responseBody;
        }
    }
}
