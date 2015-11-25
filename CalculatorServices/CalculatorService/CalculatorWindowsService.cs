using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class CalculatorWindowsService : ServiceBase
    {
        public ServiceHost serviceHost = null;

        public CalculatorWindowsService()
        {
            ServiceName = "WCFWindowsSimpleCalculator";
        }

        public static void Main()
        {
            ServiceBase.Run(new CalculatorWindowsService());
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }
            serviceHost = new ServiceHost(typeof(CalculatorService));
            serviceHost.Open();
        }


        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
