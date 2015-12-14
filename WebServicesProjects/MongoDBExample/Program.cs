using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBExample
{
    public class Program
    {
        //static MongoServer _server;
        //static MongoDatabase _database;

        protected static IMongoClient _client;
        protected static IMongoDatabase _database;


        private static void Main(string[] args)
        {
            //InsertMongoDb();

            InsertTrainDb();
            //FindAsyncrone();

        }

        private static async void FindAsyncrone()
        {
            var collection2 = _database.GetCollection<BsonDocument>("restaurants");
            var filter = new BsonDocument();
            var count = 0;
            using (var cursor = await collection2.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        // process document
                        count++;
                    }
                }
            }
        }


        public static void InsertMongoDb()
        {
            try
            {
                _client = new MongoClient();
                _database = _client.GetDatabase("test");

                var document = new BsonDocument
                {
                    {
                        "Utilisateur", new BsonDocument
                        {
                            {"id", "1"},
                            {"nom", "LAMGHARI"},
                            {"prenom", "Mohammed"},
                            {"mail", "mail"},
                            {"pseudo", "dskat747"},
                            {"mdp", "1234"},
                            {"handicap", "false"},
                            {
                                "ProfileParking", new BsonDocument
                                {
                                    {"id", "2"},
                                    {"profil", "admin"}
                                }
                            },
                            {"Reservation", new BsonDocument
                                {
                                    {"id", "15"},
                                    {"Place", new BsonDocument
                                                    {
                                                        {"id", "1"},
                                                        {"profile", "admin"},
                                                        {"mac_address", "DF,15,21,DF,00"},
                                                        {"nom", "place 01"},
                                                        {"Parking", new BsonDocument
                                                                            {
                                                                                {"adresse", "Valenciennes"},
                                                                                {"NbPlace", "150"},
                                                                                {"etat", "Operationnel"}
                                                                            }
                                                        }
                                                    }
                                    }
                                }
                            }
                        }
                    }
                };

                var collection = _database.GetCollection<BsonDocument>("test");
                //collection.InsertOne(document);


            }
            catch (Exception)
            {
                throw;
            }
        }


        public static void InsertTrainDb()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("test");

            var document = new BsonDocument
            {
                {"TrainId", "ZA747"},
                {"Coordonnees", new BsonDocument
                {
                    {"latitude", "45.6920"},
                    {"longitude", "12.54845"},
                    {"altitude", "150"},
                    {"date", DateTime.Now.ToString("s")},
                }
                }
            };

            var collection = _database.GetCollection<BsonDocument>("test");
            collection.InsertOne(document);
            //await collection.InsertOneAsync(document);
        }



    }
}