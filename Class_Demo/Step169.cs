using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Class_Demo
{
    public class Step169
    {
        Random random = new Random();
        //========== FUNWITH2 - void, overloaded
        //----- Multiply a random number by 2, print to screen
        public void FunWith2()
        {
            int value = RandomNum(1, 1000);
            value *= 2;
            Console.WriteLine("===== FunWith2() =====\nMultiply 2 with a random number between {0} and {1}:\n{2:n0}", 1, 1000, value);
        }
        //----- Input 1 number, divide by 2, print to screen
        public void FunWith2(int num1)
        {
            int value = num1/2;
            Console.WriteLine("===== FunWith2({0}) =====\nDivide {0} by 2 is {1:n0}", num1, value);
        }
        //----- Input 1 number, square the number, print to screen, return an ouput parameter
        public void FunWith2(int num1, out int value, out string fw2)
        {
            value = num1 * num1;
            fw2 = "This was my string variable output parameter:\nHaving fun with 2 on Step 169 in the C-Sharp Course";
            Console.WriteLine("===== FunWith2({0}) =====\n{0} squared is {1:n0}", num1, value);
        }


        //========== PRINT RANDOM
        public void PrintRandom(int min = 1, int max = 100)
        { 
            int value = RandomNum(min, max);
            Console.WriteLine("===== PRINT RANDOM =====\nA random number between {0} and {1}:\n{2}", min, max, value);
        }

        //========== RANDOM NUM
        public int RandomNum(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
