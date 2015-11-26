using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWPFClient.Models
{
    public class PartTimeEmployeeObj : EmployeeObj
    {
        public int HourlyPay { get; set; }

        public int HoursWorked { get; set; }
    }
}
