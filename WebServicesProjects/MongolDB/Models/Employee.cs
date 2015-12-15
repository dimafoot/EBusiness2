using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LocationAppMainServices.Models
{

    public class Employee
    {
        [BsonId]
        public ObjectId Id { get; set; }
        private int _employeeId;
        private string _name;
        private string _gender;
        private DateTime _dateofb;

        #region Get/Set

        public int EmployeeId
        {
            get
            {
                return _employeeId;
            }

            set
            {
                _employeeId = value;
            }
        }


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


        public EmployeeType EmployeeType { get; set; }

        #endregion

    }

    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
}
