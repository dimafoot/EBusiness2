using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class CalculatorService : ICalculator
    {
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Divide(double n1, double n2)
        {
            return n1 / n2;
        }

        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Substract(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}
