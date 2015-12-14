using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using LocationAppMainWebService.ServiceReference1;

namespace LocationAppMainWebService
{
    public partial class SendLocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.freegeoip.net/xml/");

            string IP = xmlDoc.DocumentElement.SelectSingleNode("/Response/IP").InnerText;
            string Latitude = xmlDoc.DocumentElement.SelectSingleNode("/Response/Latitude").InnerText.Replace('.', ',');
            string Longitude = xmlDoc.DocumentElement.SelectSingleNode("/Response/Longitude").InnerText.Replace('.', ',');


            //ServiceReference1.ITrainServices client = new TrainServicesClient();
            //client.SetTrainLocation("0.0.0.0", Latitude, Longitude, "69");

            WebServicesWCF client = new WebServicesWCF();
            //client.SetTrainLocation("0.0.0.0", Latitude, Longitude, "69");
            client.SetUserLocation();
        }
    }
}