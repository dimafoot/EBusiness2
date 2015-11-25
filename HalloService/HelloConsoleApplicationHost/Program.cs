using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleApplicationHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService.HalloService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now + " with the base address : " + host.BaseAddresses[0]);
                Console.Read();

            }
        }
    }
}
