using MongoDB.Bson.Serialization.Attributes;

namespace Helper
{
    public class Item
    {
        [BsonId]
        public int PID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}