using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BiduleService.Models
{
    public class FullTimeEmployee : Employee
    {
        private int _annualSalary;

        //[DataMember]
        public int AnnualSalary
        {
            get
            {
                return _annualSalary;
            }

            set
            {
                _annualSalary = value;
            }
        }
    }
}
