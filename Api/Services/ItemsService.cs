using Api.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Helper;


namespace Api.Services
{

    public class ItemsService
    {
        private readonly IMongoCollection<Item> _items;

        public ItemsService(IItemsDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _items = database.GetCollection<Item>(settings.ItemsCollectionName);
        }

        public List<Item> Get() =>
            _items.Find(item => true).ToList();

        public Item Get(int id) =>
            _items.Find<Item>(item => item.PID == id).FirstOrDefault();

        public Item Create(Item item)
        {
            _items.InsertOne(item);
            return item;
        }

        public List<Item> CreateMany(List<Item> items)
        {
            _items.InsertManyAsync(items);
            return items;
        }


        public void Update(int id, Item ItemIn) =>
            _items.ReplaceOne(item => item.PID == id, ItemIn);

        public void Remove(Item ItemIn) =>
            _items.DeleteOne(item => item.PID == ItemIn.PID);

        public void Remove(int id) =>
            _items.DeleteOne(item => item.PID == id);

        public void Upsert(int id, Item ItemIn) =>
            _items.ReplaceOne(new BsonDocument("_id", id), ItemIn, new ReplaceOptions { IsUpsert = true });

        public void Upsert(List<Item> items)
        {
            foreach (var item in items)
            {
                if (_items.Find<Item>(i => i.PID == item.PID).FirstOrDefault() == null)
                    Create(item);
                else
                    Update(item.PID, item);
            }
        }



    }
}
