using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    public class BasicMath
    {

        //========== VOID method
        public void PrintRandom(int num1, int num2, int min=1, int max=100, string msg="")
        {
            if (msg != "") { msg = String.Format("\nThe optional message was:\n{0}", msg); }
            int value = RandomNumber(min, max);
            value += num1;
            Console.WriteLine("===== VOID METHOD =====\nA random number between {0} and {1} was added to num1({2}) which equals {3}.\nNum2({4}) was ignored.{5}",min, max, num1, value, num2, msg);
        }

        //========== ADD method
        public int Add(int num1, int num2=3)
        {
            if (num2 == 3) { Console.WriteLine("Used default value(3)."); }
            int value = num1 + num2;
            return value;
        }
        //========== MULTIPLY OVERLOADED METHODS 
        //--- Multiply two numbers together - input 2 integers, output integer
        public int Multiply(int num1, int num2=3)
        {
            if (num2 == 3) { Console.WriteLine("Used default value(3)."); }
            int value = num1 * num2;
            return value;
        }
        //--- Multiply two numbers together then added each of the numbers to the product - input 2 strings, output integer
        public int Multiply(string num1, string num2="3")
        {
            if (num2 == "") { num2 = "3"; }
            if (num2 == "3") { Console.WriteLine("Used default value(3)."); }
            int value = (Convert.ToInt32(num1) * Convert.ToInt32(num2)) + Convert.ToInt32(num1) + Convert.ToInt32(num2);
            return value;
        }

        //--- Multiply two numbers togther - option to multiply by the reciprocal, input 2 decimals, output integer
        public int Multiply(decimal num1, decimal num2=3m, bool reciprocal=false)
        {
            if (num2 == 3m) { Console.WriteLine("Used default value(3)."); }
            int value;
            if (reciprocal)
            {
                value = (int)(num1 * (1 / num2));
            }
            else
            {
                value = (int)(num1 * num2);
            }
            return value;
        }
        //========== POWER method
        public decimal Power(int num1, int num2=3)
        {
            if (num2 == 3) { Console.WriteLine("Used default value(3)."); }
            decimal value = (decimal)Math.Pow(num1, num2);
            return value;
        }

        //========== RANDOM NUMBER
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);            
        }

    }
}
