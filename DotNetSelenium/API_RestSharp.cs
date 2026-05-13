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
            var client = new RestClient("https://reqres.in");
            var request = new RestRequest("/api/users?page=2");

            var response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}