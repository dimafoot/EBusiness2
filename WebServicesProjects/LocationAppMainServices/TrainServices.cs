using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microsoft.Maps.MapControl.WPF;

namespace LocationAppMainServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "TrainServices" à la fois dans le code et le fichier de configuration.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class TrainServices : ITrainServices
    {
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

            _locations.Add(new Location(Convert.ToDouble(lat), Convert.ToDouble(log)));

            return new Location(Convert.ToDouble(lat), Convert.ToDouble(log));
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
