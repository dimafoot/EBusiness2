using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LocationAppMainServices.Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MongolDB
{
    class Program
    {
        public static IMongoClient _client;
        public static IMongoDatabase _database;

        public static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("test");

            //var collection = _database.GetCollection<ClubMember>("club");

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

            //collection = _database.GetCollection<ClubMember>("club");

            //Console.WriteLine("List of ClubMembers in collection ...");

            //var members = collection.Find(member => member.Age == 45);


            //Console.WriteLine("List of ClubMembers in collection ...");


            var collection = _database.GetCollection<Employee>("employee");

            Employee employee = new FullTimeEmployee
            {
                EmployeeId = 1,
                Name = "LAMGHARI",
                Gender = "M",
                Dateofb = Convert.ToDateTime("21/10/1988"),
                AnnualSalary = 32000,
                EmployeeType = EmployeeType.FullTimeEmployee
            };

            Employee employee2 = new PartTimeEmployee
            {
                EmployeeId = 1,
                Name = "Csharper",
                Gender = "M",
                Dateofb = Convert.ToDateTime("21/10/1988"),
                HourlyPay = 50,
                HoursWorked = 35,
                EmployeeType = EmployeeType.PartTimeEmployee
            };

            collection.InsertOne(employee);
            collection.InsertOne(employee2);

            List<Employee> members = collection.Find(member => member.EmployeeId > 0).ToList();


            foreach (Employee document in members)
            {
                if (document.EmployeeType == EmployeeType.FullTimeEmployee)
                {
                    Employee employee0 = new FullTimeEmployee
                    {
                        EmployeeId = document.EmployeeId,
                        Name = document.Name,
                        Gender = document.Gender,
                        Dateofb = document.Dateofb,
                        AnnualSalary = 32000,
                        EmployeeType = document.EmployeeType
                    };

                    employees.Add(employee0);
                }


            }

            string url = "https://smsapi.free-mobile.fr/sendmsg?user=14958283&pass=uJSoPtJx9RqbYi&msg=Nouvelle%20Connection%20from%20Paris%20 à%20"+DateTime.Now;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream resStream = response.GetResponseStream();

            Console.WriteLine(resStream);

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
