using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiduleService.Models;
using BiduleService.Exceptions;

namespace BiduleService
{
    //[ServiceKnownType(typeof(FullTimeEmployee))]
    //[ServiceKnownType(typeof(PartTimeEmployee))]
    [ServiceContract]
    public interface IBiduleService
    {
        //[ServiceKnownType(typeof(FullTimeEmployee))]
        //[ServiceKnownType(typeof(PartTimeEmployee))]
        [FaultContract(typeof(ZeroFault))]
        [OperationContract]
        Employee GetEmployeeDB(int Id);

        [OperationContract]
        void SaveEmployee(Employee Employee);

        [OperationContract]
        List<Employee> GetEmployee();

        [OperationContract]
        Employee GetFullTimeEmployee();

        [OperationContract]
        Employee GetPartTimeEmployee();

        [OperationContract]
        string GetMessage(string nom);

        [OperationContract]
        List<Client> GetClients();

        [OperationContract]
        FullTimeClientEmployee GetEmployeeClient();

    }
}
