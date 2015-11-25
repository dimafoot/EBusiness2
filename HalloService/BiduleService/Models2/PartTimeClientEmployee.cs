using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiduleService
{
    public class PartTimeClientEmployee
    {
        private int _hourlyPay;
        private int _hoursWorked;

        #region Get/SET
        public int HourlyPay
        {
            get
            {
                return _hourlyPay;
            }

            set
            {
                _hourlyPay = value;
            }
        }

        public int HoursWorked
        {
            get
            {
                return _hoursWorked;
            }

            set
            {
                _hoursWorked = value;
            }
        }
        #endregion
    }
}
