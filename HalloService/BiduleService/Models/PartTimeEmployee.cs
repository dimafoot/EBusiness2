using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BiduleService.Models
{
    public class PartTimeEmployee : Employee
    {
        private int _hourlyPay;
        private int _hoursWorked;

        #region Get/SET
        //[DataMember]
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
        //[DataMember]
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
