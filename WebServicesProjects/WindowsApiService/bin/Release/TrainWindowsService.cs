using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApiService
{
    public class TrainWindowsService : ServiceBase
    {
        public ServiceHost serviceHost;

        public TrainWindowsService()
        {
            ServiceName = "WCFTrainWinService";
        }

        public static void Main()
        {
            ServiceBase.Run(new TrainWindowsService());
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            serviceHost = new ServiceHost(typeof(TrainServices));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            serviceHost.Close();
            serviceHost = null;
        }
    }
}
