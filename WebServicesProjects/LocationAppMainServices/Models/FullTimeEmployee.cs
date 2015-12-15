using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LocationAppMainServices.Models
{
    [DataContract]
    public class FullTimeEmployee : Employee
    {
        [DataMember]
        public int AnnualSalary { get; set; }
    }
}
