using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using LocationAppMainServices.Models;
using MongoDB.Driver;


namespace LocationAppMainServices
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EmployeeService : IEmployeeService
    {
        public static IMongoClient Client;
        public static IMongoDatabase Database;

        public Employee SaveDummyEmployee()
        {
            Client = new MongoClient();
            Database = Client.GetDatabase("test");

            var collection = Database.GetCollection<Employee>("employees");

            long i = collection.Count(member => member.EmployeeId >= 0);

            Employee employee = new FullTimeEmployee
            {
                EmployeeId = (int) (i + 1),
                Name = "LAMGHARI",
                Gender = "M",
                Dateofb = Convert.ToDateTime("21/10/1988"),
                AnnualSalary = 36000,
                EmployeeType = EmployeeType.FullTimeEmployee
            };

            Employee employee2 = new PartTimeEmployee
            {
                EmployeeId = (int) (i + 2),
                Name = "Csharper",
                Gender = "F",
                Dateofb = Convert.ToDateTime("21/10/1988"),
                HourlyPay = 50,
                HoursWorked = 35,
                EmployeeType = EmployeeType.PartTimeEmployee
            };

            Employee employee3 = new FullTimeEmployee
            {
                EmployeeId = (int) (i + 3),
                Name = "Dinari",
                Gender = "F",
                Dateofb = Convert.ToDateTime("21/10/1991"),
                AnnualSalary = 32000,
                EmployeeType = EmployeeType.FullTimeEmployee
            };

            Employee employee4 = new PartTimeEmployee
            {
                EmployeeId = (int) (i + 4),
                Name = "Hewwari",
                Gender = "M",
                Dateofb = Convert.ToDateTime("21/10/1990"),
                HourlyPay = 50,
                HoursWorked = 35,
                EmployeeType = EmployeeType.PartTimeEmployee
            };

            collection.InsertOne(employee);
            collection.InsertOne(employee2);
            collection.InsertOne(employee3);
            collection.InsertOne(employee4);

            return employee2;
        }

        public List<Employee> GetDummyEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Client = new MongoClient();
            Database = Client.GetDatabase("test");

            var collection = Database.GetCollection<Employee>("employees");

            Employee employee = new FullTimeEmployee
            {
                EmployeeId = 35,
                Name = "Dinari",
                Gender = "F",
                Dateofb = Convert.ToDateTime("21/10/1991"),
                AnnualSalary = 32000,
                EmployeeType = EmployeeType.FullTimeEmployee
            };

            Employee employee2 = new PartTimeEmployee
            {
                EmployeeId = 747,
                Name = "Hewwari",
                Gender = "F",
                Dateofb = Convert.ToDateTime("21/10/1990"),
                HourlyPay = 50,
                HoursWorked = 35,
                EmployeeType = EmployeeType.PartTimeEmployee
            };

            collection.InsertOne(employee);
            collection.InsertOne(employee2);

            //List<Employee> members = collection.Find(member => member.EmployeeId > 0).ToList();
            List<Employee> members = collection.Find(member => member.Gender == "M").ToList();

            foreach (Employee document in members)
            {
                if (document.EmployeeType == EmployeeType.FullTimeEmployee)
                {
                    Employee ftemployee = new FullTimeEmployee
                    {
                        EmployeeId = document.EmployeeId,
                        Name = document.Name,
                        Gender = document.Gender,
                        Dateofb = document.Dateofb,
                        AnnualSalary = ((FullTimeEmployee) document).AnnualSalary,
                        EmployeeType = document.EmployeeType
                    };

                    employees.Add(ftemployee);
                }
                else
                {
                    Employee ptemployee = new PartTimeEmployee
                    {
                        EmployeeId = document.EmployeeId,
                        Name = document.Name,
                        Gender = document.Gender,
                        Dateofb = document.Dateofb,
                        HourlyPay = ((PartTimeEmployee) document).HourlyPay,
                        HoursWorked = ((PartTimeEmployee) document).HoursWorked,
                        EmployeeType = document.EmployeeType
                    };

                    employees.Add(ptemployee);
                }

            }
            return employees;
        }

        public List<Employee> GetEmployeeById(int id)
        {
            List<Employee> employees = new List<Employee>();

            Client = new MongoClient();
            Database = Client.GetDatabase("test");

            var collection = Database.GetCollection<Employee>("employees");

            //List<Employee> members = collection.Find(member => member.EmployeeId > 0).ToList();
            //List<Employee> members = collection.Find(member => member.Gender == "M").ToList();
            List<Employee> members = collection.Find(member => member.EmployeeId == id).ToList();


            foreach (Employee document in members)
            {
                if (document.EmployeeType == EmployeeType.FullTimeEmployee)
                {
                    Employee ftemployee = new FullTimeEmployee
                    {
                        EmployeeId = document.EmployeeId,
                        Name = document.Name,
                        Gender = document.Gender,
                        Dateofb = document.Dateofb,
                        AnnualSalary = ((FullTimeEmployee)document).AnnualSalary,
                        EmployeeType = document.EmployeeType
                    };

                    employees.Add(ftemployee);
                }
                else
                {
                    Employee ptemployee = new PartTimeEmployee
                    {
                        EmployeeId = document.EmployeeId,
                        Name = document.Name,
                        Gender = document.Gender,
                        Dateofb = document.Dateofb,
                        HourlyPay = ((PartTimeEmployee)document).HourlyPay,
                        HoursWorked = ((PartTimeEmployee)document).HoursWorked,
                        EmployeeType = document.EmployeeType
                    };

                    employees.Add(ptemployee);
                }

            }
            return employees;
        }

    }
}
