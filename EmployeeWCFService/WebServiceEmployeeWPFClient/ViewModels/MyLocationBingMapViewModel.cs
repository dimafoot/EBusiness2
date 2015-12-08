using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Maps.MapControl.WPF;
using Prism.Mvvm;
using WebServiceEmployeeWPFClient.Models;
using WebServiceEmployeeWPFClient.ServiceReference;
using Location = Microsoft.Maps.MapControl.WPF.Location;

namespace WebServiceEmployeeWPFClient.ViewModels
{
    public class MyLocationBingMapViewModel : BindableBase
    {

        private ObservableCollection<Earthquake> _earthquakes;
        public ObservableCollection<Earthquake> Earthquakes
        {
            get { return _earthquakes; }
            set
            {
                SetProperty(ref _earthquakes,value);
            }
        }

        private Dispatcher _dispatcher;
        public Dispatcher Dispatcher
        {
            get { return _dispatcher; }
            set { _dispatcher = value; }
        }

        readonly ServiceReference.EmployeeWebServiceSoap client = new EmployeeWebServiceSoapClient();
        

        public MyLocationBingMapViewModel()
        {
            Dispatcher = this.Dispatcher;

            Thread thread = new Thread(CallWebService);
            thread.Start();

        }

        private void CallWebService()
        {
            Earthquakes = new ObservableCollection<Earthquake>();

            Random r = new Random();



            while (true)
            {
                string lat = r.Next(1, 50) + "," + r.Next(10000, 10500);
                string log = r.Next(1, 15) + "," + r.Next(40000, 40500);
                Thread.Sleep(1000);

                Application.Current.Dispatcher.Invoke((Action)(() =>
                {
                    Earthquakes.Add(new Earthquake()
                    {
                        Description = "Loca",
                        Title = "Test",
                        Location = new Location(Convert.ToDouble(lat), Convert.ToDouble(log))
                    });
                }));


                //Earthquakes.Add(new Earthquake()
                //{
                //    Description = "Loca",
                //    Title = "Test",
                //    Location = new Location(Convert.ToDouble(lat), Convert.ToDouble(log))
                //});
            }
        }
    }
}
