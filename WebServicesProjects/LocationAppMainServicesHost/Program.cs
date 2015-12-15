using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LocationAppMainServicesHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(LocationAppMainServices.TrainServices)), host2 = new ServiceHost(typeof(LocationAppMainServices.EmployeeService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now + " with the base address :" + host.BaseAddresses[0]);
                host2.Open();
                Console.WriteLine("Host started @ " + DateTime.Now + " with the base address :" + host2.BaseAddresses[0]);
                Console.Read();
            }

            //using (ServiceHost host2 = new ServiceHost(typeof(LocationAppMainServices.EmployeeService)))
            //{
            //    host2.Open();
            //    Console.WriteLine("Host started @ " + DateTime.Now + " with the base address :" + host2.BaseAddresses[0]);
            //    Console.Read();
            //}
        }
    }
}
