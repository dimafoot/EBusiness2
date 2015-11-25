using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BiduleWindowsServiceHost
{
    public partial class BiduleWindowsService : ServiceBase
    {
        ServiceHost host;

        public BiduleWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            using (host = new ServiceHost(typeof(BiduleService.BiduleService)))
            {
                host.Open();
            }
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
