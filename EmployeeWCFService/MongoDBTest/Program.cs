﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;


namespace MongoDBTest
{
    public class Entity
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }
    }

    class Program
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        static void Main(string[] args)
        {
            //ExecQueryMongoDBTest();

            LINQTutorialCall();

            //InsertToMongoDBFile();

            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("test");
            var collection = database.GetCollection<Entity>("entities");

            var entity = new Entity { Name = "Tom" };
            collection.Insert(entity);
            var id = entity.Id;

            var query = Query<Entity>.EQ(e => e.Id, id);
            entity = collection.FindOne(query);

            entity.Name = "Dick";
            collection.Save(entity);

            var update = Update<Entity>.Set(e => e.Name, "Harry");
            collection.Update(query, update);

            collection.Remove(query);


        }

        private static void LINQTutorialCall()
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);


        }


        private static async void ExecQueryMongoDBTest()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("test");

            //var collection = _database.GetCollection<BsonDocument>("restaurants");
            //var filter = new BsonDocument();
            //var count = 0;
            //using (var cursor = await collection.FindAsync(filter))
            //{
            //    while (await cursor.MoveNextAsync())
            //    {
            //        var batch = cursor.Current;
            //        foreach (var document in batch)
            //        {
            //            // process document
            //            count++;
            //        }
            //    }
            //}


            //var collection = _database.GetCollection<BsonDocument>("restaurants");
            //var filter = Builders<BsonDocument>.Filter.Eq("borough", "Manhattan");
            //var result = collection.Find(filter).ToListAsync();


            //var collection = _database.GetCollection<BsonDocument>("restaurants");
            //var builder = Builders<BsonDocument>.Filter;
            //var filter = builder.Eq("cuisine", "Italian") & builder.Eq("address.zipcode", "10075");
            //var result = collection.Find(filter).ToListAsync();

            var collection = _database.GetCollection<BsonDocument>("restaurants");
            var filter = new BsonDocument();
            var sort = Builders<BsonDocument>.Sort.Ascending("borough").Ascending("address.zipcode");
            var result = collection.Find(filter).Sort(sort).ToListAsync();

            
        }

        private static async void InsertToMongoDBFile()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("test");


            var collection = _database.GetCollection<BsonDocument>("restaurants");

            var document = new BsonDocument
                                            {
                                                { "address" , new BsonDocument
                                                    {
                                                        { "street", "2 Avenue" },
                                                        { "zipcode", "10075" },
                                                        { "building", "1480" },
                                                        { "coord", new BsonArray { 73.9557413, 40.7720266 } }
                                                    }
                                                },
                                                { "borough", "Manhattan" },
                                                { "cuisine", "Italian" },
                                                { "grades", new BsonArray
                                                    {
                                                        new BsonDocument
                                                        {
                                                            { "date", new DateTime(2014, 10, 1, 0, 0, 0, DateTimeKind.Utc) },
                                                            { "grade", "A" },
                                                            { "score", 11 }
                                                        },
                                                        new BsonDocument
                                                        {
                                                            { "date", new DateTime(2014, 1, 6, 0, 0, 0, DateTimeKind.Utc) },
                                                            { "grade", "B" },
                                                            { "score", 17 }
                                                        }
                                                    }
                                                },
                                                { "name", "Vella" },
                                                { "restaurant_id", "41704620" }
                                            };

            await collection.InsertOneAsync(document);
        }
    }
}
