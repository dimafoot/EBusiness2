using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceEmployeeWPFClient.Models;

namespace WebServiceEmployeeWPFClient.Events
{
    class EarthquakeEventArgs : EventArgs
    {
        public List<Earthquake> Locations { get; set; }

        public EarthquakeEventArgs(List<Earthquake> locations)
        {
            Locations = locations;
        }
    }
}
