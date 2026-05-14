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
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/users");
            request.AddHeader("Accept", "application/json");

            var response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}