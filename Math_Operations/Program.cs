using System;

namespace Math_Operations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer (whole number)");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int total1 = num1 * 50;
            Console.WriteLine("" + num1 + " * 50 = " + total1);

            Console.WriteLine("\nPlease enter another integer (whole number)");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total2 = num2 + 25;
            Console.WriteLine("" + num1 + " + 25 = " + total2);

            Console.WriteLine("\nPlease enter another integer (whole number)");
            int num3 = Convert.ToInt32(Console.ReadLine());
            decimal total3 = num3 / 12.5m;
            Console.WriteLine("" + num3 + " + 12.5 = " + total3);

            Console.WriteLine("\nPlease enter another integer (whole number)");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool result = num4 > 50;
            Console.WriteLine("Is " + num4 + " greater than 50: " + result);

            Console.WriteLine("\nPlease enter another integer (whole number)");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int result2 = num5 % 7;
            Console.WriteLine("The remainer of " + num5 + " divided by 7 is " + result2);

            //----- HOLD OPEN - till enter is pressed
            Console.ReadLine();
        }
    }
}
