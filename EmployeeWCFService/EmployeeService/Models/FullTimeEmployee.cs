using System.Runtime.Serialization;

namespace EmployeeService.Models
{
    [DataContract]
    public class FullTimeEmployee : Employee
    {
        [DataMember]
        public int AnnualSalary { get; set; }
    }
}