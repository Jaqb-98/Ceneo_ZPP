using NUnit.Framework;
using Api;
using Api.Services;
using Helper;

namespace WebParserTest
{
    public class Tests
    {
        private WebsiteParser wp;
        
        [SetUp]
        public void Setup()
        {
            wp = new WebsiteParser();
            ApiHelper.InitializeClient();
        }

        [Test]
        public void Test1()
        {
            var items = ItemsProcessor.LoadItems("narty");

            Assert.Pass();
        }
    }
}