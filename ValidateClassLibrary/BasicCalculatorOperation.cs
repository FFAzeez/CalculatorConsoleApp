using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTwo
{
    public class BasicCalculatorOperation
    {
        
        public double AdditionValue(double firstNum, double secondNum)
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
        public string SquareValue(double firstNum, double secondNum)
        {
            return $"The square of {firstNum} is {Math.Pow(firstNum, 2)}" +
                $"and The square of {secondNum} is {Math.Pow(secondNum, 2)}";
        }
        public string SquareRootValue(double firstNum, double secondNum)
        {
            return $"The square root of {firstNum} is {Math.Sqrt(firstNum)}" +
                $"and The square root of {secondNum} is {Math.Sqrt(secondNum)}";
        }
        public string CubeValue(double firstNum, double secondNum)
        {
            return $"The cube of {firstNum} is {Math.Pow(firstNum, 3)}" +
                $"and The cube of {secondNum} is {Math.Pow(secondNum, 3)}";
        }
        public string CubeRootValue(double firstNum, double secondNum)
        {
            return $"The cube root of {firstNum} is {Math.Cbrt(firstNum)}" +
                $"and The cube root of {secondNum} is {Math.Cbrt(secondNum)}";
        }

    }
}
