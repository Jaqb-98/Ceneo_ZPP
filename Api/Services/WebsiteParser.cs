using Api.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Api.Interfaces;

namespace Api.Services
{

    public class WebsiteParser: IWebsiteParser
    {
        /// <summary>
        /// Returns parsed items from Ceneo
        /// </summary>
        /// <param name="searchedItem">Name of searching product</param>
        /// <param name="page">Number of page on website</param>
        /// <returns>List of items</returns>
        public List<Item> GetItems(string searchedItem, int page)
        {

            var url = UrlBuilder(searchedItem, page);

            List<Item> items = new List<Item>();

            foreach (var item in GetNodeCollection(url))
            {

                items.Add(ItemParser(item));

            }

            return items;
        }

        private HtmlNodeCollection GetNodeCollection(Uri url)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);

            var productList = htmlDoc.DocumentNode.SelectNodes("//div[@class='cat-prod-row js_category-list-item js_clickHashData js_man-track-event ']");

            return productList;
        }

        private Uri UrlBuilder(string searchedPhrase, int page)
        {
            var path = new StringBuilder();
            path.Append($";szukaj-{searchedPhrase}");

            if (page > 1)
                path.Append($";0020-30-0-0-{page - 1}.htm");

            var uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "http";
            uriBuilder.Host = "www.ceneo.pl";
            uriBuilder.Path = path.ToString();
            Uri url = uriBuilder.Uri;

            return url;
        }

        private Item ItemParser(HtmlNode node)
        {
            var img = node.Descendants("img")
                          .First()
                          .GetAttributeValue("src", String.Empty);

            if (img.EndsWith("png") || String.IsNullOrEmpty(img))
                img = node.Descendants("img").First().GetAttributeValue("data-original", String.Empty);

            var name = node.GetAttributeValue("data-productname", String.Empty);


            var price = node.GetAttributeValue("data-price", String.Empty);
            if (String.IsNullOrEmpty(price))
                price = node.GetAttributeValue("data-productminprice", String.Empty);

            return new Item()
            {
                PID = int.Parse(node.GetAttributeValue("data-pid", String.Empty)),
                ProductName = name,
                Category = node.GetAttributeValue("data-GACategoryName", String.Empty),
                Price = PriceParser(price),
                Image = img
            };


        }

        private decimal PriceParser(string price)
        {
            if (decimal.TryParse(price, NumberStyles.Number, new CultureInfo("en-US", false).NumberFormat, out decimal parsedPrice)) { }
            return parsedPrice;
        }
    }
}
