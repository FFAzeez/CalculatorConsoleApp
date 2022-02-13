using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsoleApp
{
    /// <summary>
    /// In this class there will be combinations of exponential, logarithms and factorial operation
    /// </summary>
    public class Exponential
    {
        /// <summary>
        /// This the exponential operation method
        /// </summary>
        /// <param name="number"></param>
        /// <param name="baseNumber"></param>
        /// <returns></returns>
        public double ExponentialOperation(double number, double baseNumber)
        {
            double result = 1;
            for (int i = 0; i < baseNumber; i++)
            {
                result *= number;
            }

            return result;
        }
        /// <summary>
        /// This is the logarithms operation
        /// </summary>
        /// <param name="number"></param>
        /// <param name="baseNumber"></param>
        /// <returns></returns>
        public double LogarithmOperation(double number, double baseNumber)
        {
            return Math.Log(number, baseNumber);
        }
        /// <summary>
        /// This is the factorial 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double FactorialOperation(double number)
        {
            if (number == 0)
                return 1;
            

            return number * FactorialOperation(number - 1);
        }
    }
}
