using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithDerivedDataType
{
    class Calculator
    {
        //public double firstNumber;
        //public double secondNumber;
        //public double result;


        public double GetAddition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double GetSubtraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double GetMultiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double GetDivision(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
       
    }
}
