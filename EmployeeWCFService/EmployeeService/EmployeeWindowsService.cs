using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    public class EmployeeWindowsService : ServiceBase
    {
        public ServiceHost serviceHost;

        public EmployeeWindowsService()
        {
            ServiceName = "EmployeeWcfService";
        }

        public static void Main()
        {
            ServiceBase.Run(new EmployeeWindowsService());
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            serviceHost = new ServiceHost(typeof(EmployeeService));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            serviceHost.Close();
            serviceHost = null;
        }
    }
}
