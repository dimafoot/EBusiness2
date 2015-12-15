using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LocationAppMainServices.Models;

namespace LocationAppMainServices
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee SaveDummyEmployee();

        [OperationContract]
        List<Employee> GetDummyEmployees();

        [OperationContract]
        List<Employee> GetEmployeeById(int id);
    }
}
