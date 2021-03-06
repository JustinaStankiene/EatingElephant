using NUnit.Framework;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloApi.Tests
{
    public class HelloApiGetMethodShould
    {
        [Test]
        [TestCase("Juste")]
        [TestCase("Ruta")]
        [TestCase("Eimante")]
        [TestCase("Gediminas")]
        public async Task ReturnGreetingAndName(string name)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://localhost:44375/helloapi?name={name}";

                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Get
                };

                using (var response = client.SendAsync(request).Result)
                {
                    var responseString = await response.Content.ReadAsStringAsync();

                    Assert.AreEqual($"Hello, {name}", responseString);
                }
            }

        }
    }
}