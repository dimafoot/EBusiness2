using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Maps.MapControl.WPF;
using MongoDAO;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

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
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("http://www.freegeoip.net/xml/");

            //string IP = xmlDoc.DocumentElement.SelectSingleNode("/Response/IP").InnerText;
            //string Latitude = xmlDoc.DocumentElement.SelectSingleNode("/Response/Latitude").InnerText.Replace('.', ',');
            //string Longitude = xmlDoc.DocumentElement.SelectSingleNode("/Response/Longitude").InnerText.Replace('.', ',');

            //Console.WriteLine(IP);
            //Console.WriteLine(Latitude);
            //Console.WriteLine(Longitude);

            //var xloc = new Location(Convert.ToDouble(Latitude), Convert.ToDouble(Longitude));

            //foreach (XmlNode xmlNode in xmlDoc.DocumentElement.SelectSingleNode("/Response"))
            //    Console.WriteLine(xmlNode.InnerText);
            //Console.ReadKey();



            Console.ReadKey();
            //InsertMongoDb();

            //InsertTrainDb();
            //FindAsyncrone();

            //Page_Load();

            QueryMongoDB();

        }

        private static void QueryMongoDB()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("test");

            var collection = _database.GetCollection<TDocument>("test");

        }

        private static void Page_Load()
        {
            XmlDocument xdoc = new XmlDocument();//xml doc used for xml parsing

            xdoc.Load(
                "http://latestpackagingnews.blogspot.com/feeds/posts/default"
                );//loading XML in xml doc

            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("entry");//reading node so that we can traverse thorugh the XML

            foreach (XmlNode xNode in xNodelst)//traversing XML
            {

            }
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
                {"TrainId", "ICE_747"},
                {"Coordonnees", new BsonDocument
                {
                    {"latitude", "45.6920"},
                    {"longitude", "12.54845"},
                    {"altitude", "150"},
                    {"date", DateTime.Now.ToString("s")}
                }
                }
            };

            var collection = _database.GetCollection<BsonDocument>("test");
            collection.InsertOne(document);
            //await collection.InsertOneAsync(document);
        }



    }

    internal class User
    {
        public string TrainId { get; set; }
        public Coordonnees Coordonnees { get; set; }
        public string Paye { get; set; }
        public string Ville { get; set; }
        public string Code_Postale { get; set; }

    }

    internal class Coordonnees
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string altitude { get; set; }
        public string date { get; set; }


    }
}