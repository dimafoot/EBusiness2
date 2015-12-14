using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microsoft.Maps.MapControl.WPF;

namespace LocationAppMainServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ITrainServices" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ITrainServices
    {
        [OperationContract]
        int Add(int firstNumber, int secondNumber);

        [OperationContract]
        List<string> GetCalculations();

        [OperationContract]
        Location GetRadomLocation();

        [OperationContract]
        Location SetTrainLocation(string ip, string latitude, string longitude, string alt);

        [OperationContract]
        Location SetUserLocationByIp(string ip);

        [OperationContract]
        List<Location> GetTrainLocations();

    }
}
