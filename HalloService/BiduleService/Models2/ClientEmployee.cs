using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BiduleService
{
    [KnownType(typeof(FullTimeClientEmployee))]
    [KnownType(typeof(FullTimeClientEmployee))]
    [DataContract]
    public class ClientEmployee
    {
        private int _id;
        private string _name;
        private string _gender;
        private DateTime _dateofb;

        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
        public EmployeeClientType Type { get; set; }

        public static FullTimeClientEmployee GetEmployee()
        {
            FullTimeClientEmployee employee = new FullTimeClientEmployee
            {
                Id = 1,
                Name = "LAMGHARI",
                Gender = "M",
                Dateofb = Convert.ToDateTime("21/10/1988"),
                AnnualSalary = 3000,
                Type = EmployeeClientType.FullTimeClientEmployee
            };

            return employee;
        }

    }

    public enum EmployeeClientType
    {
        FullTimeClientEmployee = 1,
        PartTimeClientEmployee = 2
    }



}
