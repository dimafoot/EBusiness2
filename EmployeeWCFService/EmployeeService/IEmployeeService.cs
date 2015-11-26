using EmployeeService.Exceptions;
using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [FaultContract(typeof(ZeroFault))]
        [OperationContract]
        Employee GetEmployeeDB(int Id);

        [OperationContract]
        void SaveEmployee(Employee Employee);

        [OperationContract]
        List<Employee> GetAllEmployees();

        [OperationContract]
        Employee GetEmployeeDBDummy(int Id);

        [OperationContract]
        List<Employee> GetAllEmployeesDummy();
    }
}
