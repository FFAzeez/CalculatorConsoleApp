using System;
using ClassLibraryTwo;

namespace CalculatorConsoleApp
{
    public class Calculator
    {
        private static BasicCalculatorOperation Basic = new BasicCalculatorOperation();
        private static TrigonometryOperation TrigonometryOperator = new TrigonometryOperation();
        private static Exponential Exponential = new Exponential();
        private static Validate Validate = new Validate();
        /// <summary>
        /// This is the starting point of this Code
        /// </summary>
        public static void Start()
        {

            bool check = true;
            string operate;
            double firstNumber;
            string sign;
            string triSign;
            double secondNumber;
            double angle;
            double facNumber;
            double expNumber; 
            double expBaseNumber;
            double logNumber; 
            double logBaseNumber;

            while (check)
            {
                        Console.WriteLine("\n\t\t\tBasic operation(bas)\n\n\t\t\tTrigonometry operation(tri)\n" +
                         "\n\t\t\tExponential operation(exp)\n" +
                             "\n\t\t\tLogarithm operation(log)\n\n\t\t\tFactorial operation(fac)\n");
                        operate = Console.ReadLine();
                        operate = operate.ToLower();
                while(Validate.OperationInputCheck(operate)== "Invalid input")
                {
                    Console.WriteLine("Re-enter the operation you want to perform!!");
                    operate= Console.ReadLine(); 
                }
                  switch (operate)
                  {  
                    case "bas":
                        Console.WriteLine("\t\tIn this operation you can carry out"
                                    + " +, *, /, %, sq, sqrt, cb, cbrt");
                        Console.Write("Enter first number: ");
                        string firstNum = Console.ReadLine();
                        while (Validate.NumberOperationCheck(firstNum) == "Invalid input")
                        {
                          Console.WriteLine("Re-enter the first number you want to perform!!");
                          firstNum = Console.ReadLine();
                        }
                        firstNumber = Convert.ToDouble(firstNum);
                        Console.Write("Enter sign: ");
                        sign = Console.ReadLine();
                        while (Validate.SignInputCheck(sign) == "Invalid input")
                        {
                            Console.WriteLine("Re-enter the sign you want to perform!!");
                            sign = Console.ReadLine();
                        }
                        Console.Write("Enter second number: ");
                        string secondNum = Console.ReadLine();
                        while (Validate.NumberOperationCheck(secondNum) == "Invalid input")
                        {
                            Console.WriteLine("Re-enter the second number you want to perform!!");
                            secondNum = Console.ReadLine();
                        }
                        secondNumber = Convert.ToDouble(secondNum);
                        switch (sign)
                        {
                            case "+":
                                Console.WriteLine(Basic.AdditionValue(firstNumber, secondNumber));
                                break;
                            case "-":
                                Console.WriteLine(Basic.SubtractionValue(firstNumber, secondNumber));
                                break;
                            case "*":
                                Console.WriteLine(Basic.MultiplicationValue(firstNumber, secondNumber));
                                break;
                            case "/":
                                Console.WriteLine(Basic.DivisionValue(firstNumber, secondNumber)); ;
                                break;
                            case "%":
                                Console.WriteLine(Basic.ModuleValue(firstNumber, secondNumber));
                                break;
                            case "sq":
                                Console.WriteLine(Basic.SquareValue(firstNumber, secondNumber));
                                break;
                            case "sqrt":
                                Console.WriteLine(Basic.SquareRootValue(firstNumber, secondNumber));
                                break;
                            case "cb":
                                Console.WriteLine(Basic.CubeValue(firstNumber, secondNumber));
                                break;
                            case "cbrt":
                                Console.WriteLine(Basic.CubeRootValue(firstNumber, secondNumber));
                                break;
                        }
                      break;
                    case "tri":
                        Console.WriteLine("\tIn this operation enter any of the following trigonometry" +
                                 " cos, sin, tan, cos^-1, sin^-1, tan^-1");
                        Console.Write("Enter the trigonometry sign: ");
                        triSign = Console.ReadLine();
                        while (Validate.OperationInputCheck(triSign) == "Invalid input")
                        {
                            Console.WriteLine("Re-enter the operation you want to perform!!");
                            triSign = Console.ReadLine();
                        }
                        Console.Write("Enter the angle: ");
                        string angleString=Console.ReadLine();
                        while (Validate.NumberOperationCheck(angleString) == "Invalid input")
                        {
                            Console.WriteLine("Re-enter the first number you want to perform!!");
                            angleString = Console.ReadLine();
                        }
                        angle = Convert.ToDouble(angleString);
                        switch (triSign)
                        {

                             case "cos":
                                 Console.WriteLine(TrigonometryOperator.CosineOperationRad(angle));
                                 break;
                             case "sin":
                                 Console.WriteLine(TrigonometryOperator.SineOperation(angle));
                                 break;
                             case "tan":
                                 Console.WriteLine(TrigonometryOperator.TangentOperation(angle));
                                 break;
                             case "cos^-1":
                                 Console.WriteLine(TrigonometryOperator.InverseCosineOperation(angle));
                                 break;
                             case "sin^-1":
                                 Console.WriteLine(TrigonometryOperator.InverseSineOperation(angle));
                                 break;
                             case "tan^-1":
                                 Console.WriteLine(TrigonometryOperator.InverseTangentOperation(angle));
                                 break;
                        }
                        break;
                    case "exp":
                                Console.WriteLine("\tIn this Operation you can do exponential");
                                Console.Write("Enter the number: ");
                                expNumber = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Enter the exponential Value: ");
                                expBaseNumber = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(Exponential.ExponentialOperation(expNumber, expBaseNumber));
                                break;
                            case "log":
                                Console.WriteLine("\tIn this Operation you will carry out logarithms with logNum & logBaseNum");
                                Console.WriteLine("Enter the number: ");
                                logNumber  = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter the base number: ");
                                logBaseNumber = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(Exponential.LogarithmOperation(logNumber, logBaseNumber));
                                break;
                            case "fac":
                                Console.WriteLine("\tIn this Operation you will carry out factorial with one Number");
                                Console.WriteLine("Enter the number: ");
                                facNumber = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(Exponential.FactorialOperation(facNumber));
                                break;
                        }
            }
                    //if (operate=="bas" && firstNumber == )
                    //Console.WriteLine("");
                    //Console.WriteLine(" Will you like to proceed with the operation! ");
                    //string condition = Console.ReadLine();
                    //condition = condition.ToLower();
                    //if (condition == "yes")
                    //{
                    //    continue;
                    //}
                    //else if (condition == "no") 
                    //{
                    //    break;
                    //}
        }
    }
}

