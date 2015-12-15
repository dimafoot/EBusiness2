using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace LocationAppMainServices.Models
{
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    [DataContract]
    public class Employee
    {

        private int _employeeId;
        private string _name;
        private string _gender;
        private DateTime _dateofb;

        #region Get/Set

        [BsonId]
        public ObjectId Id { get; set; }

        [DataMember]
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
        public EmployeeType EmployeeType { get; set; }

        #endregion

    }

    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
}
