using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BiduleService.Models
{
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    //[DataContract]
    public class Employee
    {
        private int _id;
        private string _name;
        private string _gender;
        private DateTime _dateofb;

        #region Get/Set
        //[DataMember]
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        //[DataMember]
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        //[DataMember]
        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }
        //[DataMember]
        public DateTime Dateofb
        {
            get
            {
                return _dateofb;
            }

            set
            {
                _dateofb = value;
            }
        }
        //[DataMember]
        public EmployeeType Type { get; set; }

        #endregion


        public static List<Employee> GetEmployee()
        {
            List<Employee> listEmployee = new List<Employee>();

            Employee employee = new Employee
            {
                Id = 1,
                Name = "LAMGHARI",
                Gender = "M",
                Dateofb = Convert.ToDateTime("21/10/1988"),

            };

            listEmployee.Add(employee);
            return listEmployee;
        }

        public static FullTimeEmployee GetFullTimeEmployee()
        {
            FullTimeEmployee fte = new FullTimeEmployee
            {
                Id = 1,
                Name = "LAMGHARI",
                Gender = "M",
                Dateofb = Convert.ToDateTime("21/10/1988"),
                Type = EmployeeType.FullTimeEmployee,
                AnnualSalary = 32000
            };
            return fte;
        }


        public static PartTimeEmployee GetPartTimeEmployee()
        {
            PartTimeEmployee pte = new PartTimeEmployee
            {
                Id = 1,
                Name = "ELGHOMARI",
                Gender = "M",
                Dateofb = Convert.ToDateTime("21/10/1990"),
                Type = EmployeeType.PartTimeEmployee,
                HourlyPay = 15,
                HoursWorked = 250
            };
            return pte;
        }

    }

    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }

}
