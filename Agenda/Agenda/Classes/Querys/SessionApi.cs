using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Agenda.Classes.Querys
{
    internal static class SessionApi
    {
        public static string sessionToken;
        public static DateTime expiration;

        public static string SessionToken { get => sessionToken; set => sessionToken = value; }

        public static void GetSession()
        {
            var data = new
            {
                accessToken = "Ch0OvuJoZLbCQy1OhS5OJKibOq058ZwkVaujVM-c8CxB72z2bV",
                source = "Postman"
            };

            var client = new HttpClient();

            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync("https://api.e-boekhouden.nl/v1/session", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseBody = response.Content.ReadAsStringAsync().Result;
                var doc = JsonDocument.Parse(responseBody);
                SessionToken = doc.RootElement.GetProperty("token").GetString();
                var expireTime = doc.RootElement.GetProperty("expiresIn").GetInt64();
                expiration = DateTime.Now.AddSeconds(expireTime);
            }
        }

        public static void DeleteSession()
        {
            if (SessionToken != null && DateTime.Now < expiration)
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + SessionToken);

                var response = client.DeleteAsync("https://api.e-boekhouden.nl/v1/session").Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Session is deleted");
                    SessionToken = "";
                    expiration = DateTime.Now;
                }
            }
        }
    }
}
