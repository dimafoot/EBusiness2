using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsProject
{
    public delegate void HalloFunctionDelegate(string strMsg);


    public class Program
    {




        static void Main(string[] args)
        {
            HalloFunctionDelegate del = new HalloFunctionDelegate(Hallo);
            del("Hallo from Delegate");

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 1, Nom = "Nom1", Salaire = 2100, Experience = 2 });
            empList.Add(new Employee() { Id = 2, Nom = "Nom2", Salaire = 2500, Experience = 4 });
            empList.Add(new Employee() { Id = 3, Nom = "Nom3", Salaire = 1800, Experience = 1 });
            empList.Add(new Employee() { Id = 4, Nom = "Nom4", Salaire = 3000, Experience = 5 });

            Employee.PromoteEmployee(empList, emp => emp.Experience >= 2 );

            //Define a delegate
            //Define an event based on that delegate 
            //Raise the event

            var video = new Video() { Title = "video 1" };
            var videoEncoder = new VideoEncoder();


            videoEncoder.VideoEncoded += VideoEncoder_VideoEncoded;

            videoEncoder.Encode(video);

            Console.Read();
        }

        private static void VideoEncoder_VideoEncoded(object sourve, EventArgs args)
        {
            throw new NotImplementedException();
        }

        public static void Hallo(string strMsg)
        {
            Console.WriteLine(strMsg);
        }
    }

    public delegate bool IsPromotable(Employee empl);

    public class Employee
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Salaire { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> empList, IsPromotable isEligibleToPtomote)
        {
            foreach (Employee emp in empList)
            {
                if (isEligibleToPtomote(emp))
                {
                    Console.WriteLine(emp.Nom + " is Promoted");
                }

            }
        }

    }

}
