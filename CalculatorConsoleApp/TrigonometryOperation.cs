using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsoleApp
{
    public class TrigonometryOperation
    {
       
        public double CosineOperationRad(double rad)
        {
            return Math.Cos(rad);
        }
        public double CosineOperationDeg(double angle)
        {
            return Math.Cos((angle * Math.PI) / 180);
        }
        public double SineOperation(double degree)
        {
            return Math.Sin(degree);
        }
        public double SineOperationDeg(double angle)
        {
            return Math.Sin((angle * Math.PI) / 180);
        }
        public double TangentOperation(double degree)
        {
            return Math.Tan(degree);
        }
        public double TangentOperationDeg(double angle)
        {
            return Math.Tan((angle * Math.PI) / 180);
        }
        public double InverseCosineOperation(double angle)
        {
            return Math.Cosh(angle);
        }
        public double InverseCosineOperationDeg(double angle)
        {
            return Math.Cosh((angle*Math.PI)/180);
        }
        public double InverseSineOperation(double degree)
        {
            return Math.Sinh(degree);
        }
        public double InverseSineOperationDeg(double angle)
        {
            return Math.Sinh((angle*Math.PI)/180);
        }
        public double InverseTangentOperation(double degree)
        {
            return Math.Tanh(degree);
        }
        public double InverseTangentOperationDeg(double angle)
        {
            return Math.Tanh((angle*Math.PI)/180);
        }
    }
}
