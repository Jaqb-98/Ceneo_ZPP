using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Helper
{
    /// <summary>
    /// Item data model
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Item Id
        /// </summary>
        [BsonId]
        public int PID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        /// <summary>
        /// Image url
        /// </summary>
        public string Image { get; set; }
        public Dictionary<string, string> Params { get; set; }
        public string ShopUrl { get; set; }
    }
}