using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BiduleService
{
    public class BiduleWindowsService : ServiceBase
    {
        public ServiceHost servicehost = null;

        public BiduleWindowsService()
        {
            ServiceName = "WCFBiduleWindowsService";
        }

        public static void Main()
        {
            ServiceBase.Run(new BiduleWindowsService());
        }

        protected override void OnStart(string[] args)
        {
            if (servicehost != null)
            {
                servicehost.Close();
                servicehost = null;
            }

            servicehost = new ServiceHost(typeof(BiduleService));
            servicehost.Open();
        }

        protected override void OnStop()
        {
            if (servicehost != null)
            {
                servicehost.Close();
                servicehost = null;
            }
        }
    }
}
