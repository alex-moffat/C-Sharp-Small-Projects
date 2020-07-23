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
        //========== MULTIPLY method
        public int Multiply(int num1, int num2)
        {
            int value = num1 * num2;
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
