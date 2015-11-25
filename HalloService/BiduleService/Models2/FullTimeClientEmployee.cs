using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiduleService
{
    public class FullTimeClientEmployee : ClientEmployee
    {
        private int _annualSalary;

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
