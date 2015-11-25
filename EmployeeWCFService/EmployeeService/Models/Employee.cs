using System;
using System.Runtime.Serialization;

namespace EmployeeService.Models
{
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    [DataContract]
    public class Employee
    {
        private int _id;
        private string _name;
        private string _gender;
        private DateTime _dateofb;

        #region Get/Set
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
        public EmployeeType Type { get; set; }

        #endregion

    }

    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
}
