using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using LocationAppMainWebService.ServiceReference1;
using Microsoft.Maps.MapControl.WPF;

namespace LocationAppMainWebService
{
    /// <summary>
    /// Description résumée de WebServicesWCF
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicesWCF : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public int Add(int firstNumber, int secondNumber)
        {
            ServiceReference1.ITrainServices client = new TrainServicesClient();
            return client.Add(firstNumber, secondNumber);
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculationsList()
        {
            ServiceReference1.ITrainServices client = new TrainServicesClient();
            return client.GetCalculations().ToList();
        }

        [WebMethod(EnableSession = true)]
        public Location GetRandomLocation()
        {
            ServiceReference1.ITrainServices client = new TrainServicesClient();
            return client.GetRadomLocation();
        }

        [WebMethod(EnableSession = true)]
        public List<Location> GetLocations()
        {
            ServiceReference1.ITrainServices client = new TrainServicesClient();
            return client.GetTrainLocations().ToList();
        }

    }
}
