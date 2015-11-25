using System;
using System.ServiceModel;

namespace BiduleServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(BiduleService.BiduleService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now + " with the base address : " + host.BaseAddresses[0]);
                Console.Read();

            }
        }
    }
}
