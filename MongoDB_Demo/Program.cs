using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MongoDB_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");

            //PersonModel person = new PersonModel
            //{
            //    FirstName = "Joe",
            //    LastName = "Smith",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "101 Oak Street",
            //        City = "New York",
            //        ZipCode = "18512"
            //    }
            //};



           // db.InsertRecord("Users", person);

            var recs = db.LoadRecords<NameModel>("Users");


            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.FirstName } { rec.LastName } ");

               
            }

            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{ rec.Id }: {rec.FirstName } { rec.LastName } ");

            //    if (rec.PrimaryAddress != null)
            //        Console.WriteLine(rec.PrimaryAddress.City);
            //}


            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("ed8a8d53-925d-4f0d-ab09-e0f66b009908"));

            //oneRec.DateOfBirth = new DateTime(1982, 10, 31, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord("Users", oneRec.Id, oneRec);

            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);

            Console.ReadLine();
        }
    }

    public class NameModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }


        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        [Obsolete]
        public void UpsertRecord<T>(string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);

            var result = collection.ReplaceOne(
                new BsonDocument("_id", id),
                record,
                new UpdateOptions { IsUpsert = true });
        }

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
