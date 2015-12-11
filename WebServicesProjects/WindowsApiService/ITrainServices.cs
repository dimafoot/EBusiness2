using System.Collections.Generic;
using System.ServiceModel;
using Microsoft.Maps.MapControl.WPF;

namespace WindowsApiService
{
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
        List<Location> GetTrainLocations();

    }
}
