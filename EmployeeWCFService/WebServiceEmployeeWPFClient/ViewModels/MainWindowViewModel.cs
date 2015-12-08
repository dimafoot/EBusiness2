using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Xml.Linq;
using Prism.Mvvm;
using WebServiceEmployeeWPFClient.ServiceReference;

namespace WebServiceEmployeeWPFClient.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        ServiceReference.EmployeeWebServiceSoap client = new EmployeeWebServiceSoapClient();

        private int _id = 15;

        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id,value); }
        }

        private List<ServiceReference.Location> lst;
        public MainWindowViewModel()
        {
            Thread thread = new Thread(CallWebService);
            thread.Start();

            client.SetTrainLocation(15,60);


            var address = "48 Rue des prevoyants, stains";
            var requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false", Uri.EscapeDataString(address));

            var request = WebRequest.Create(requestUri);
            var response = request.GetResponse();
            var xdoc = XDocument.Load(response.GetResponseStream());

            var result = xdoc.Element("GeocodeResponse").Element("result");
            var locationElement = result.Element("geometry").Element("location");
            var lat = locationElement.Element("lat");
            var lng = locationElement.Element("lng");

        }

        private void CallWebService()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Id = client.GetRadomNumber();
            }
        }
    }
}
