using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    public class BasicMath
    {
                
        //========== ADD method
        public int Add(int num1, int num2)
        {
            int value = num1 + num2;
            return value;
        }
        //========== MULTIPLY OVERLOADED METHODS 
        //--- Multiply two numbers together - input 2 integers, output integer
        public int Multiply(int num1, int num2)
        {
            int value = num1 * num2;
            return value;
        }
        //--- Multiply two numbers together then added each of the numbers to the product - input 2 strings, output integer
        //--- Multiply two numbers together - input 2 integers, output integer
        public int Multiply(string num1, string num2)
        {
            int value = (Convert.ToInt32(num1) * Convert.ToInt32(num2)) + Convert.ToInt32(num1) + Convert.ToInt32(num2);
            return value;
        }

        //--- Multiply two numbers togther - option to multiply by the reciprocal, input 2 decimals, output integer
        public int Multiply(decimal num1, decimal num2, bool reciprocal=false)
        {
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
        public decimal Power(int num1, int num2)
        {
            decimal value = (decimal)Math.Pow(num1, num2);
            return value;
        }
        
    }
}
