using NUnit.Framework;
using RestSharp;
using System.Net;

namespace ApiTesting
{
    public class ApiTest
    {
        [Test]
        public void GetUsersTest()
        {
            var options = new RestClientOptions("https://jsonplaceholder.typicode.com")
            {
                MaxTimeout = 10000
            };
            var client = new RestClient(options);
            var request = new RestRequest("/users");
            request.AddHeader("Accept", "application/json");

            var response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}