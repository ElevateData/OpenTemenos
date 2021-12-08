using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests
{
    [TestClass()]
    public class CredentialManagement
    {
        public static HttpClient HttpClient = new();

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            // Executes once before the test run. (Optional)
            var root = new ConfigurationBuilder()
                .AddJsonFile("testsettings.json")
                .Build();

            var configuration = root.GetSection(nameof(TemenosCredential));

            var temenosCredential = new TemenosCredential() {
                ApiKey = configuration["ApiKey"], UserName = configuration["Username"],
                Password = configuration["Password"]
            };

            if (!string.IsNullOrWhiteSpace(temenosCredential.ApiKey))
                HttpClient.DefaultRequestHeaders.Add("apiKey", temenosCredential.ApiKey);
            else if (!string.IsNullOrWhiteSpace(temenosCredential.UserName)) {
                var authToken = Encoding.ASCII.GetBytes($"{temenosCredential.UserName}:{temenosCredential.Password}");
                HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));
            }
        }
    }
}