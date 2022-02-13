using System;

namespace ClassLibraryTwo
{
    public class Validate
    {
        public string OperationInputCheck(string operation)
        {
           return operation != "bas" && operation != "tri" && operation != "exp"
               && operation != "log" && operation != "fac" ? "Invalid input" : operation.Trim(); 
            
        }
        public string NumberOperationCheck(string number)
        {
            return double.TryParse(number, out _) == true ? number.Trim() : "Invalid input";
        }
        public string SignInputCheck(string sign)
        {
            return sign != "+" && sign != "-" && sign != "*"
                && sign != "/" && sign != "%" && sign != "%" 
                && sign != "sq" && sign != "sqrt" && sign != "cb"
                && sign != "cbrt" ? "Invalid input" : sign.Trim();
        }

        public string TrigonometrySignCheck(string angle)
        {
            return angle != "cos" && angle != "sin" && angle != "tan"&& angle != "cos^-1"
                && angle != "sin^-1" && angle != "tan^-1" ? "Invalid input" : angle.Trim();
        }

        public string YesCheck(string yes)
        {
            return yes != "yes" ? "Invalid input" : yes.Trim();
        }
    }
}
