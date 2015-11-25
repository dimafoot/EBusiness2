using System.Runtime.Serialization;

namespace EmployeeService.Models
{
    [DataContract]
    public class PartTimeEmployee : Employee
    {
        [DataMember]
        public int HourlyPay { get; set; }

        [DataMember]
        public int HoursWorked { get; set; }
    }
}