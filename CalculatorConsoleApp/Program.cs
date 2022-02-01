using System;

namespace CalculatorConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tEnter your name: ");
            string name = Console.ReadLine();
        
            Console.WriteLine($"\t\tWelcome {name} Choose the operation you will to carry out");
            Console.WriteLine("\n\t\t\tBasic operation(bas)\n\n\t\t\tTrigonometry operation(tri)\n" +
                "\n\t\t\tExponential operation(exp)\n" +
                "\n\t\t\tLogarithm operation(log)\n\n\t\t\tFactorial operation(fac)\n");
            string operation = Console.ReadLine();
            Console.WriteLine($"The selected operation is {operation}");
            Console.WriteLine("");
            switch (operation)
            {
                case "bas":
                    Console.WriteLine("\t\t\tIn this operation you can carry out" +
                "\n\t\t\tAddition(+)\n\t\t\tSubtraction(-)\n\t\t\tMultiplication(*)" +
                "\n\t\t\tDivision(/)\n\t\t\tModules(%)");
                    Console.WriteLine("Enter first number: ");
                    double firstNum = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter sign: ");
                    var sign = Console.ReadLine();

                    Console.WriteLine("Enter second number: ");
                    double secondNum = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    var ans = BasicOperation(sign, firstNum,secondNum);
                    Console.WriteLine(ans);
                    break;
                case "tri":
                    Console.WriteLine("\t\t\tIn this operation you can carry out the below operations" +
                "\n\t\t\tCosine(cos)\n\t\t\tSine(sin)\n\t\t\tTangent(tan)\n\t\t\tInverseCosine(cosh)" +
                "\n\t\t\tInverseSine(sinh)\n\t\t\tInverseTangent(tanh)");

                    Console.WriteLine("Enter the trigonometry sign: ");
                    string s = Console.ReadLine();

                    Console.WriteLine("Enter the number: ");
                    double atr = double.Parse(Console.ReadLine());
                    var trig = TrigonometryOperation(s,atr);
                    Console.WriteLine(trig);

                    Console.WriteLine("\nEnter deg to converter to degree");
                    string c = Console.ReadLine();
                    var trigonometry = new TrigonometryOperation();
                    if (c == "deg")
                    {
                        Console.WriteLine($"Cosine degree {trigonometry.CosineOperationDeg(atr)}" +
                        $"\nSine degree {trigonometry.SineOperationDeg(atr)}" +
                        $"\nTangent degree {trigonometry.TangentOperationDeg(atr)}" +
                        $"\nInverse of Cosine {trigonometry.InverseCosineOperationDeg(atr)}" +
                        $"\nInverse of Sine {trigonometry.InverseSineOperationDeg(atr)}" +
                        $"\nInverse of Tangent {trigonometry.InverseTangentOperationDeg(atr)}");
                    }
                    break;
                case "exp":
                    Console.WriteLine("\tIn this Operation you can carry out square,square,cube,cuberoot, exponential");
                    Console.WriteLine("Enter the number: ");
                    double number = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the exponential Value: ");
                    double baseNum = double.Parse(Console.ReadLine());
                    var a =ExponentialOperation(number,baseNum);
                    Console.WriteLine(a);
                    break;
                case "log":
                    Console.WriteLine("\tIn this Operation you will carry out logarithms");
                    Console.WriteLine("Enter the number: ");
                    double num = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the base number: ");
                    double basNum = double.Parse(Console.ReadLine());
                    var an = LogarithmOperation(num, basNum);
                    Console.WriteLine(an);
                    break;
                case "fac":
                    Console.WriteLine("\tIn this Operation you will carry out factorial");
                    Console.WriteLine("Enter the number: ");
                    double fa = double.Parse(Console.ReadLine());
                    var factor = FactorialOperation(fa);
                    Console.WriteLine(factor);
                    break;
            }

            //Console.WriteLine("Do you want to perform another Operation");
            //string conti = Console.ReadLine();

        } 

        public static double BasicOperation(string sign,double firstNum, double secondNum)
        {
            
            var basic = new BasicCalculatorOperation();
            double result = 0;
            switch (sign)
            {
                case "+":
                    result +=basic.AdditionValue(firstNum, secondNum);
                    break;
                case "-":
                    result += basic.SubtractionValue(firstNum, secondNum);
                    break;
                case "*":
                    result += basic.MultiplicationValue(firstNum, secondNum);
                    break;
                case "/":
                    result += basic.DivisionValue(firstNum, secondNum);
                    break;
                case "%":
                    result += basic.ModuleValue(firstNum, secondNum);
                    break;
            }

            return result;

        }

        public static double TrigonometryOperation(string s, double angle)
        {
            double result = 0;
            var trigonometry = new TrigonometryOperation();
            switch (s)
            {
                case "cos":
                    result+=trigonometry.CosineOperationRad(angle);
                    break;
                case "sin":
                    result += trigonometry.SineOperation(angle);
                    break;
                case "tan":
                    result += trigonometry.TangentOperation(angle);
                    break;
                case "cosh":
                    result += trigonometry.InverseCosineOperation(angle);
                    break;
                case "sinh":
                    result += trigonometry.InverseSineOperation(angle);
                    break;
                case "tanh":
                    result += trigonometry.InverseTangentOperation(angle);
                    break;

            }

            return result;
            
          
        }

        public static double ExponentialOperation(double n, double b)
        {
            double res = 1;
            for(int i=0; i<b; i++)
            {
                res *= n;
            }

            return res;
        }

        public static double LogarithmOperation(double num,double ba)

        {
            return Math.Log(num, ba);
        }

        public static double FactorialOperation(double number)
        {
            double result = 1;
            for(int i = 1; i <= number; i++)
            {
                result *= i;
            }

           return result;
        }
    }
}
