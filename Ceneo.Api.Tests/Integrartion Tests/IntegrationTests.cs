using Api;
using Helper;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ceneo.Api.Tests.Integrartion_Tests
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public IntegrationTests(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("api/Items")]
        [InlineData("api/Items/Parse?name=gry&page=1")]
        public async Task Get_Endpoints(string endpoint)
        {
            //Arrange

            //Act
            var response = await _client.GetAsync(endpoint);
            //Assert
            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task UpsertListOfItems()
        {
            //Arrange
            var endpoint = "api/Items/UpsertItems";

            var items = new List<Item>()
            {
                new Item(),
                new Item(),
                new Item()
            };
            var itemsJson = JsonConvert.SerializeObject(items);
            var httpContent = new StringContent(itemsJson, Encoding.UTF8, "application/json");
            //Act
            var response = await _client.PutAsync(endpoint, httpContent);
            //Assert
            Assert.True(response.IsSuccessStatusCode);
        }
    }
}
