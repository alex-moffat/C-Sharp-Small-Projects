using System;
using System.Reflection.Emit;
using System.Xml.Schema;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //===== GREETING
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
            //===== INPUTS
            Console.WriteLine("Please enter the package weight:");
            float iWeight = float.Parse(Console.ReadLine());
            if (iWeight > 50) //===== OVER WEIGHT TEST
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter package width:");
                float iWidth = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter package height:");
                float iHeight = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter package length:");
                float iLength = float.Parse(Console.ReadLine());
                if (iWidth + iHeight + iLength > 50) //===== OVER DIMENSION TEST
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else //===== TOTAL DISPLAY
                {
                    float total = (iWidth * iHeight * iLength * iWeight) / 100;
                    Console.WriteLine("\nYour estimated total for shipping this package is: {0:c}\nThank you.", total);
                }
            }


            ////=============== IF/THEN EXAMPLES ===============
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi {0}, what is the current temperature?", name);
            //short currentTemp = Convert.ToInt16(Console.ReadLine());

            //int roomTemp = 70;
            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("It is cooler than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}
            ////===== TERNARY OPERATOR
            //string tempCompare = (currentTemp == roomTemp) ? "It is exactly room temperature" : "It is not exactly room temperature";
            //Console.WriteLine(tempCompare);

            //Console.WriteLine("\n{0}, what is your favorite whole number?", name);
            //int favNum = Convert.ToInt32(Console.ReadLine());
            //string result = favNum == 13 ? "You have an awesome favorite number" : "You do NOT have an awesome favorite number";
            //Console.WriteLine(result);

            //===== HOLD OPEN - till enter is pressed
            Console.ReadLine();            
        }
    }
}
