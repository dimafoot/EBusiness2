using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MongolDB
{
    class Program
    {
        public static IMongoClient _client;
        public static IMongoDatabase _database;

        



        static void Main(string[] args)
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("test");

            var collection = _database.GetCollection<ClubMember>("club");

            //var collection = _database.GetCollection<BsonDocument>("test");
            //var document = new BsonDocument
            //    {
            //        {"","" }
            //    };

            //ClubMember cm = new ClubMember()
            //{
            //    Age = 27,
            //    Cars = new List<Cars>() { new Cars() { Id = 0, Name = "Renault" }, new Cars() { Id = 1, Name = "PS" } },
            //    Forename = "LAMGHARI",
            //    Lastname = "Mohammed"
            //};

            //collection.InsertOne(cm);

            collection = _database.GetCollection<ClubMember>("club");

            Console.WriteLine("List of ClubMembers in collection ...");

            var members = collection.Find(member => member.Age == 45);


            Console.WriteLine("List of ClubMembers in collection ...");
            Console.Read();

        }
    }

    internal class ClubMember
    {
        public int Age { get; set; }
        public List<Cars> Cars { get; set; }
        public string Forename { get; set; }
        public string Lastname { get; set; }
    }

    internal class Cars
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
