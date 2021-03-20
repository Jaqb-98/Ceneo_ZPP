using System;
using System.Net.Http;
using Xunit;
using Ceneo.Api;
using Api.Controllers;
using Api.Interfaces;
using Moq;
using System.Linq;
using Api.Services;
using Api.Models;
using Helper;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Ceneo.Api.Tests
{
    public class ItemsControllerTests
    {
        private readonly ItemsController _controller;


        private readonly Mock<IItemsService> _itemsService = new Mock<IItemsService>();
        private readonly Mock<IWebsiteParser> _websiteParser = new Mock<IWebsiteParser>();

        public ItemsControllerTests()
        {
            _controller = new ItemsController(_itemsService.Object, _websiteParser.Object);
        }

        [Fact]
        public void Get_ShouldReturnItem_WhenItemExists()
        {
            //Arrange
            int id = 5462348;
            var item = new Item()
            {
                ProductName = "Test product",
                Category = "Test category",
                Price = 100.00m,
                Image = "//image.jpg",
                Params = new Dictionary<string, string>(),
                ShopUrl = "http://shop.com",

            };

            _itemsService.Setup(x => x.Get(id)).Returns(item);


            //Act
            var result = _controller.Get(id);

            //Assert
            Assert.Equal(item, result.Value);

        }

        [Fact]
        public void Get_ShouldReturnNothing_WhenItemDoesntExist()
        {
            //Arrange
            _itemsService.Setup(x => x.Get(It.IsAny<int>())).Returns((Item)null);


            //Act
            var result = _controller.Get(5);

            //Assert
            Assert.Null(result.Value);

        }



        [Fact]
        public void GetItemsThatMatchSearchingPhrase_ShouldReturnListOfItems_WhenItemsExist()
        {
            //Arrange
            var searchingPhrase = "searchingPhrase";

            var items = new List<Item>()
            {
                new Item(),
                new Item(),
                new Item(),
            };

            _itemsService.Setup(x => x.Get(searchingPhrase)).Returns(items);


            //Act
            var result = _controller.Get(searchingPhrase);

            //Assert
            Assert.Equal(items, result.Value);

        }

        [Fact]
        public void GetItemsThatMatchSearchingPhrase_ShouldReturnNothing_WhenItemsDeasntExist()
        {
            //Arrange
            _itemsService.Setup(x => x.Get(It.IsAny<string>())).Returns((List<Item>)null);

            //Act
            var result = _controller.Get("searchingPhrase");

            //Assert
            Assert.Null(result.Value);
        }


        [Fact]
        public void GetParsedItems_ShouldReturnListofItems_WhenItemsExist()
        {
            //Arrange
            var searchingPhrase = "searching";

            var items = new List<Item>()
            {
                new Item(),
                new Item(),
                new Item()
            };

            _websiteParser.Setup(x => x.GetItems(searchingPhrase, 1)).Returns(items);

            //Act
            var result = _controller.Get(searchingPhrase, 1);

            //Assert
            Assert.Equal(items, result.Value);
        }

        [Fact]
        public void GetParsedItems_ShouldReturnNothing_WhenItemsDoesntExist()
        {
            //Arrange
            _websiteParser.Setup(x => x.GetItems(It.IsAny<string>(),It.IsAny<int>()))
                .Returns((List<Item>)null);
            //Act
            var result = _controller.Get("searchingPhrase",1);

            //Assert
            Assert.Null(result.Value);
        }



    }

}
