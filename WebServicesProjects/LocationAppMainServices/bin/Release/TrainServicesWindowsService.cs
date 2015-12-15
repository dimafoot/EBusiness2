using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace LocationAppMainServices
{
    public class TrainServicesWindowsService : ServiceBase
    {
        public ServiceHost serviceEmployeeHost;
        public ServiceHost serviceTrainHost;

        public TrainServicesWindowsService()
        {
            ServiceName = "WCFWindowsService";
        }

        public static void Main()
        {
            Run(new TrainServicesWindowsService());
        }

        protected override void OnStart(string[] args)
        {
            if (serviceTrainHost != null)
            {
                serviceTrainHost.Close();
            }
            serviceTrainHost = new ServiceHost(typeof(TrainServices));
            serviceTrainHost.Open();

            if (serviceEmployeeHost != null)
            {
                serviceEmployeeHost.Close();
            }
            serviceEmployeeHost = new ServiceHost(typeof(EmployeeService));
            serviceEmployeeHost.Open();

        }

        protected override void OnStop()
        {
            serviceTrainHost.Close();
            serviceTrainHost = null;

            serviceEmployeeHost.Close();
            serviceEmployeeHost = null;
        }
    }
}
