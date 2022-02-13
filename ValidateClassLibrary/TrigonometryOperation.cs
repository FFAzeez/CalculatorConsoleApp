using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTwo
{
    /// <summary>
    /// ....
    /// </summary>
    public class TrigonometryOperation
    {
        /// <summary>
        /// This performs a cosine operation...
        /// </summary>
        /// <param name="rad"></param>
        /// <returns>Returns the .....</returns>

        public double TrigonometryOperationInverse(string sign, double answerTrigonometry)
        {
            double result = 0;
            switch (sign)
            {
                
            }
            return result;
        }
        public double TrigonometryOperate(string s, double angle)
        {
            double result = 0;
            switch (s)
            {
                case "cos":
                    result = CosineOperationRad(angle);
                    break;
                case "sin":
                    result = SineOperation(angle);
                    break;
                case "tan":
                    result = TangentOperation(angle);
                    break;
            }

            return result;
        }
        
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
        public double InverseCosineOperation(double answer)
        {
            return Math.Acos(answer);
        }
        public double InverseCosineOperationDeg(double answer)
        {
            return Math.Acos(answer);
        }
        public double InverseSineOperation(double answer)
        {
            return Math.Acos(answer);
        }
        public double InverseSineOperationDeg(double answer)
        {
            return Math.Sinh((answer * Math.PI) / 180);
        }
        public double InverseTangentOperation(double answer)
        {
            return Math.Acos(answer);
        }
        public double InverseTangentOperationDeg(double angle)
        {
            return Math.Tanh((angle * Math.PI) / 180);
        }
    }
}
