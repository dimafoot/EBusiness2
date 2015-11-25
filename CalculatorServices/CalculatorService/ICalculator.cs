﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    [ServiceContract(Name ="http://localhsot.CalculatorService.Sample")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double n1, double n2);

        [OperationContract]
        double Substract(double n1, double n2);

        [OperationContract]
        double Multiply(double n1, double n2);

        [OperationContract]
        double Divide(double n1, double n2);
    }
}
