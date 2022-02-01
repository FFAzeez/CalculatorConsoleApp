using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsoleApp
{
    public class BasicCalculatorOperation
    {
        public double AdditionValue(double firstNum,double secondNum)
        {
            return firstNum + secondNum;
        }
        public double SubtractionValue(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        public double MultiplicationValue(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public double DivisionValue(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
        public double ModuleValue(double firstNum, double secondNum)
        {
            return firstNum % secondNum;
        }

    }
}
