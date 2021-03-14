using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGathering
{
    public class MongoDataBase
    {
        private IMongoDatabase db;

        public MongoDataBase(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public void InsertRecords<T>(string table, List<T> record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertMany(record);
        }


    }
}
