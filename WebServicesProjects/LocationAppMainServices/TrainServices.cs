using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microsoft.Maps.MapControl.WPF;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LocationAppMainServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "TrainServices" à la fois dans le code et le fichier de configuration.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class TrainServices : ITrainServices
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        private List<string> _calculations;
        private List<Location> _locations;

        public int Add(int firstNumber, int secondNumber)
        {

            if (_calculations == null)
            {
                _calculations = new List<string>();
            }

            string strTransaction = firstNumber.ToString() + " + "
                + secondNumber.ToString()
                + " = " + (firstNumber + secondNumber).ToString();

            _calculations.Add(strTransaction);

            return firstNumber + secondNumber;
        }

        public List<string> GetCalculations()
        {
            if (_calculations == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not performed any calculations");
                return calculations;
            }
            else
            {
                return _calculations ;
            }
        }

        public Location GetRadomLocation()
        {
            if (_locations == null)
            {
                _locations = new List<Location>();
            }

            Random r = new Random();
            string lat = r.Next(10, 40) + "," + r.Next(10000, 10500);
            string log = r.Next(1, 15) + "," + r.Next(40000, 40500);
            double alt = r.Next(0, 3500) ;


            _locations.Add(new Location(Convert.ToDouble(lat), Convert.ToDouble(log)));


            #region SetInDB

            _client = new MongoClient();
            _database = _client.GetDatabase("test");

            var document = new BsonDocument
                                    {
                                        {"TrainId", "Dskat747"},
                                        {"Coordonnees", new BsonDocument
                                        {
                                            {"latitude", Convert.ToDouble(lat)},
                                            {"longitude", Convert.ToDouble(log)},
                                            {"altitude", alt},
                                            {"date", DateTime.Now.ToString("s")},
                                        }
                                        }
                                    };

            var collection = _database.GetCollection<BsonDocument>("test");
            collection.InsertOne(document);

            #endregion


            return new Location(Convert.ToDouble(lat), Convert.ToDouble(log),alt);
        }


        public List<Location> GetTrainLocations()
        {
            if (_locations == null)
            {
                _locations = new List<Location>();
                _locations.Add(new Location(0, 0));
                return _locations;
            }
            else
            {
                return _locations;
            }
        }







    }
}
