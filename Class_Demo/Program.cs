using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //===== STEP 182
            Console.WriteLine("\n========== STEP 182 ==========");
            Employee employee2 = new Employee() { FirstName = "Alexander", LastName = "Hamilton", Id = 2 };
            employee2.Quit(); //uses default message from employee method
            IQuittable iQuittable = new Employee() { FirstName = "Aaron", LastName = "Burr", Id = 3 };
            iQuittable.Quit(); // uses default message from IQuit method (even though it can't be implemented)
            IQuittable iQuittable2 = new Employee() { FirstName = "Donald", LastName = "Duck", Id = 4 };
            iQuittable2.Quit("Can you be the president");

            //===== STEP 179
            Console.WriteLine("\n========== STEP 179 ==========");
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student" , Id = 1};
            employee1.SayName();
            Console.WriteLine("Employee Id: " + employee1.Id);

            //===== CREATE CLASS OBJECT
            BasicMath basic = new BasicMath();

            //===== MULTIPLE STEPS DEMONSTRATED
            Console.WriteLine("\n========== MULTIPLE EXAMPLES ==========");
            bool valid = false;
            while (!valid)
            {
                try
                {
                    Console.WriteLine("Pick a number to do some math with:");
                    string s1 = Console.ReadLine();
                    int pick1 = Convert.ToInt32(s1);
                    decimal d1 = Convert.ToInt64(pick1);
                    Console.WriteLine("OPTIONAL: Pick a another number to do some math with:");
                    string s2 = Console.ReadLine();
                    //===== RANDOM - assigned to second number if not selected
                    int pick2 = (s2 == "") ? basic.RandomNumber(1, 10) : Convert.ToInt32(s2);
                    decimal d2 = Convert.ToInt64(pick2);
                    //===== CALL METHODS - with and without second value print results to console
                    Console.WriteLine("========== basic.Add()");
                    Console.WriteLine("{0:n0} + {1:n0} = {2:n0}", pick1, pick2, basic.Add(pick1, pick2));
                    Console.WriteLine("{0} + default = {1:n0}", pick1, basic.Add(pick1));
                    Console.WriteLine("========== basic.Multiply()");
                    Console.WriteLine("{0:n0} x {1:n0} = {2:n0}", pick1, pick2, basic.Multiply(pick1, pick2));
                    Console.WriteLine("{0} x default = {1:n0}", pick1, basic.Multiply(pick1));
                    Console.WriteLine("{0} multiplied by the reciprocal of {1} = {2:n0}", d1, d2, basic.Multiply(d1, d2, true));
                    Console.WriteLine("{0} multiplied by the reciprocal of default = {1:n0}", d1, basic.Multiply(num1:d1, reciprocal:true));
                    Console.WriteLine("({0} x {1}) + {0} + {1} = {2:n0}", s1, s2, basic.Multiply(s1, s2));
                    Console.WriteLine("({0} x default) + {0} + default = {1:n0}", s1, basic.Multiply(s1));
                    Console.WriteLine("========== basic.Power()");
                    Console.WriteLine("{0:n0} to the power of {1:n0} = {2:n0}", pick1, pick2, basic.Power(pick1, pick2));
                    Console.WriteLine("{0:n0} to the power of default = {1:n0}", pick1, basic.Power(pick1));
                    //--- VOID METHOD
                    basic.PrintRandom(pick1, pick2);
                    basic.PrintRandom(num1: pick1, num2: 4, max: 50);
                    basic.PrintRandom(num1: 2, num2: 6, min: 20, max: 50);
                    basic.PrintRandom(num1: 5, num2: 13, msg: "Having fun with C#... But not as much as Python!");

                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oops...something went wrong:");
                    Console.WriteLine(e.Message);
                }
            }

            //===== STEP 169
            Console.WriteLine("\n========== STEP 169 ==========");
            Step169 step169 = new Step169();
            string outText;
            valid = false;
            while (!valid)
            {
                try
                {
                    Console.WriteLine("Pick a number to divide by 2:");
                    int pick1 = Convert.ToInt32(Console.ReadLine());
                    //--- calling void method
                    step169.FunWith2(pick1);
                    //--- calling overloaded method
                    step169.FunWith2();
                    valid = true;
                    //--- calling method with output parameter
                    step169.FunWith2(pick1, out int value, out outText);
                    Console.WriteLine(outText);
                    //--- calling method in a static class
                    float C = ConvertTemp.FahrenheitToCelsius((float)value);
                    float F = ConvertTemp.CelsiusToFahrenheit((float)value);
                    Console.WriteLine("Sending output parameter from FunWith2 to ConvertTemp static Class:\n{0:n0}F is {1:n}C\n{0:n0}C is {2:n}F", value, C, F);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oops...something went wrong:");
                    Console.WriteLine(e.Message);
                }
            }


            //===== HOLD OPEN - till enter is pressed
            Console.ReadLine();
        }
    }
}
