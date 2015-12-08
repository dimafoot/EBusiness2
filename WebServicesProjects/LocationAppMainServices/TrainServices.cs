using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocationAppMainServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "TrainServices" à la fois dans le code et le fichier de configuration.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class TrainServices : ITrainServices
    {
        static List<string> _calculations;

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


    }
}
