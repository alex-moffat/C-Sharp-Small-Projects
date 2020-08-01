using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //===== CONSOLE COLOR
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //===== STEP 179 =====
            Console.WriteLine("\n========== STEP 179 ==========");
            Employee<string> employee1 = new Employee<string> { FirstName = "Sample", LastName = "Student", Id = 1, Things = { "Study Hard", "Play Hard", "Take Breaks" } };
            employee1.SayName();
            Console.WriteLine("Employee Id: " + employee1.Id);

            //===== STEP 182 =====
            Console.WriteLine("\n========== STEP 182 ==========");
            Employee<string> employee2 = new Employee<string> { FirstName = "Alexander", LastName = "Hamilton", Id = 2, Things = { "Those who stand for nothing fall for everything.", "I never expect a perfect work from an imperfect man.", "A nation which can prefer disgrace to danger is prepared for a master, and deserves one." } };
            employee2.Quit(); //uses default message from employee class method
            IQuittable iQuittable = new Employee<string> { FirstName = "Aaron", LastName = "Burr", Id = 3 };
            iQuittable.Quit(); // uses default message from IQuittable interface method (even though it can't be implemented)
            IQuittable iQuittable2 = new Employee<string> { FirstName = "Donald", LastName = "Duck", Id = 4 };
            iQuittable2.Quit("Can you be the president");

            //===== STEP 187 =====
            Console.WriteLine("\n========== STEP 187 ==========");
            Employee<string> employee3 = new Employee<string> { FirstName = "George", LastName = "Washington", Id = 3, Things = { "It is better to offer no excuse than a bad one.", "Human happiness and moral duty are inseparably connected.", "Guard against the impostures of pretended patriotism." } };
            Employee<string> employee4 = new Employee<string> { FirstName = "Donald", LastName = "Trump", Id = 4, Things = { "Despite the constant negative press covfefe.", "There was no collusion. Everybody knows there was no collusion.", "I think we've done more than perhaps any president in the first 100 days." } };
            Console.WriteLine("{0} {1} == {2} {3} = {4}", employee2.FirstName, employee2.LastName, employee3.FirstName, employee3.LastName, employee2 == employee3);
            //--- created ReturnName() method in Employee abstract class to access IQuittable interface properties, can't access direcly like above
            Console.WriteLine("{0} == {1} = {2}", employee3.ReturnName(), employee4.ReturnName(), employee3 == employee4);
            Console.WriteLine("{0} != {1} = {2}", employee3.ReturnName(), employee4.ReturnName(), employee3 != employee4);
            //--- NOTE: can cast interface object to employee class object to make comparison to an Employee class object 
            Console.WriteLine("{0} == {1} = {2}", employee4.ReturnName(), iQuittable2.ReturnName(), employee4 == (Employee<string>)iQuittable2);

            //===== STEP 190 =====
            Console.WriteLine("\n========== STEP 190 ==========");
            Employee<string> employee16 = new Employee<string> { FirstName = "Abraham", LastName = "Lincoln", Id = 16, Things = { "America will never be destroyed from the outside. If we falter and lose our freedoms, it will be because we destroyed ourselves.", "Nearly all men can stand adversity, but if you want to test a man's character, give him power.", "I would rather be a little nobody, then to be a evil somebody." } };
            Employee<int> employee5 = new Employee<int> { FirstName = "Leonardo", LastName = "\"Fibonacci\" Bonacci", Id = 16, Things = { 0, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987 } };

            Console.WriteLine("{0} is know for these quotes:", employee1.ReturnName());
            employee1.SayThings();
            Console.WriteLine("\nFounding father {0} is know for these quotes:\n{1}", employee2.ReturnName(), employee2.ReturnThings());
            Console.WriteLine("President {0} is know for these quotes:\n{1}", employee3.ReturnName(), employee3.ReturnThings());
            Console.WriteLine("President {0} is know for these quotes:\n{1}", employee16.ReturnName(), employee16.ReturnThings());
            Console.WriteLine("President {0} is know for these quotes:\n{1}", employee4.ReturnName(), employee4.ReturnThings());
            Console.WriteLine("{0} is know for these numbers: {1}", employee5.ReturnName(), employee5.ReturnThings(newline: false));

            //===== STEP 200 =====
            Console.WriteLine("\n========== STEP 200 ==========");
            Number piNum = new Number() { Amount = 3.14159265359m };
            Console.WriteLine("My STRUCT Number (piNum) Amount = {0}", piNum.Amount);
            Console.WriteLine("===== COPY piNum --> piSqu");
            Number piSqu = piNum;
            Console.WriteLine("My STRUCT Number (piSqu) Amount = {0}", piSqu.Amount);
            Console.WriteLine("===== SQUARE piSqu Amount");
            piSqu.Amount *= piSqu.Amount;
            Console.WriteLine("My STRUCT Number (piNum) Amount = {0:f5}", piNum.Amount);
            Console.WriteLine("My STRUCT Number (piSqu) Amount = {0:f5}", piSqu.Amount);

            //===== STEP 203 =====
            Console.WriteLine("\n========== STEP 203 ==========");
            Employee<int> e1 = new Employee<int> { FirstName = "Joe", LastName = "Montana", Id = 1, Things = { 1979, 1994 } };
            Employee<int> e2 = new Employee<int> { FirstName = "Joe", LastName = "Namath", Id = 2, Things = { 1965, 1977 } };
            Employee<int> e3 = new Employee<int> { FirstName = "Joe", LastName = "Flacco", Id = 3, Things = { 2008, 2020 } };
            Employee<int> e4 = new Employee<int> { FirstName = "Tom", LastName = "Brady", Id = 4, Things = { 2000, 2020 } };
            Employee<int> e5 = new Employee<int> { FirstName = "Payton", LastName = "Manning", Id = 5, Things = { 1998, 2015 } };
            Employee<int> e6 = new Employee<int> { FirstName = "John", LastName = "Elway", Id = 6, Things = { 1983, 1998 } };
            Employee<int> e7 = new Employee<int> { FirstName = "Roger", LastName = "\"Staubach", Id = 7, Things = { 1964, 1980 } };
            Employee<int> e8 = new Employee<int> { FirstName = "Dan", LastName = "Marino", Id = 8, Things = { 1983, 2000 } };
            Employee<int> e9 = new Employee<int> { FirstName = "Steve", LastName = "Young", Id = 9, Things = { 1984, 1999 } };
            Employee<int> e10 = new Employee<int> { FirstName = "Brett", LastName = "Favre", Id = 10, Things = { 1991, 2010 } };
            //--- Created new class 'Staff' to hold employees
            Staff<int> nfl = new Staff<int>();
            //--- Use overloaded operator in staff class to add new employees to staff
            nfl = nfl + e1 + e2 + e3 + e4 + e5 + e6 + e7 + e8 + e9 + e10;
            Console.WriteLine("NFL quarterbacks added to staff: {0}", nfl.Employees.Count());
            
            //--- Use foreach loop to create filtered list by first name
            Console.WriteLine("\n//===== Use foreach loop to create list of employees filtered by first name");
            List<Employee<int>> joeList = nfl.GetEmployees(fName: "Joe", lamb: false);
            Console.WriteLine("Listing {0} employees with the first name \"Joe\":", joeList.Count());
            foreach (Employee<int> e in joeList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }
            
            //--- Use lambda expression to create filtered list by first name
            Console.WriteLine("\n//===== Use lambda expression to create list of employees filtered by first name");
            joeList = nfl.GetEmployees(fName: "Joe", lamb: true);
            Console.WriteLine("Listing {0} employees with the first name \"Joe\":", joeList.Count());
            foreach (Employee<int> e in joeList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }

            //--- Use lambda expression to create filtered list, created overloaded operator in staff class
            Console.WriteLine("\n//===== Use lambda expression to create a filtered list by ID");
            List<Employee<int>> IDList = nfl > 5;
            Console.WriteLine("\nListing {0} employees with ID > 5:", IDList.Count());
            foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }
            IDList = nfl >= 5;
            Console.WriteLine("\nListing {0} employees with ID >= 5:", IDList.Count());
            foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }
            IDList = nfl < 5;
            Console.WriteLine("\nListing {0} employees with ID < 5:", IDList.Count());
            foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }
            IDList = nfl <= 5;
            Console.WriteLine("\nListing {0} employees with ID <= 5:", IDList.Count());
            foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }
            IDList = nfl == 5;
            Console.WriteLine("\nListing {0} employees with ID == 5:", IDList.Count());
            foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }
            IDList = nfl != 5;
            Console.WriteLine("\nListing {0} employees with ID != 5:", IDList.Count());
            foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }

            //===== STEP 203 =====
            const string stepNum = "STEP 230";
            Console.WriteLine("\n========== {0} ==========", stepNum);
            var title = "Installing a new software";
            var body = new List<string>()
            {
                "See the license agreement,",
                "skip reading,",
                "click\"I agree\".",
                "Install."
            };
            Poem poem = new Poem(title, body);
            poem.DisplayPoem();


            //===== MULTIPLE STEPS DEMONSTRATED
            Console.WriteLine("\n========== MULTIPLE EXAMPLES ==========");
            //--- CREATE CLASS OBJECT
            BasicMath basic = new BasicMath();
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
