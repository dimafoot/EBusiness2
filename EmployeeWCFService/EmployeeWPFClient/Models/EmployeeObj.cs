using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWPFClient.Models
{
    public class EmployeeObj
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Dateofb { get; set; }
        public EmployeeTypeObj Type { get; set; }
        //public int AnnualSalary { get; set; }
        //public int HourlyPay { get; set; }
        //public int HoursWorked { get; set; }
    }

    public enum EmployeeTypeObj
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
}
