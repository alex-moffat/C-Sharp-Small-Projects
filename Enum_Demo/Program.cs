using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Demo
{
    class Program
    {
        //===== ENUM - custom variable
        enum DaysOfWeek { sunday, monday, tuesday, wednesday, thursday, friday, saturday }
        static void Main(string[] args)
        {
            //===== CONSOLE COLOR
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            DayOfWeek wk = DateTime.Today.DayOfWeek; // system enum variable
            Console.WriteLine(wk);
            Console.WriteLine(Convert.ToInt32(wk));

            Console.WriteLine("\n========== ENUM DEMO ==========");
            //===== USER INPUT
            bool valid = false;
            string strInput;
            DaysOfWeek theDay;
            //---VALIDATE - using try/except method
            Console.WriteLine("\n===== USING try/catch method");
            while (!valid)
            {
                try
                {
                    Console.WriteLine("\nEnter the current day of the week:");
                    strInput = Console.ReadLine().ToLower();
                    theDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), strInput);
                    Console.WriteLine("You picked {0}.", char.ToUpper(theDay.ToString()[0]) + theDay.ToString().Substring(1));
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter an actual day of the week:");
                    Console.WriteLine(e.Message);
                }
            }
            //---VALIDATE - using tryparse() method
            Console.WriteLine("\n===== USING tryparse() method");
            valid = false;
            while (!valid)
            {
                Console.WriteLine("\nEnter the current day of the week:");
                strInput = Console.ReadLine().ToLower();
                if (Enum.TryParse(strInput, true, out theDay))
                {
                    if (wk.ToString().ToLower() == theDay.ToString())
                    {
                        Console.WriteLine("{0} == {1} = {2}", wk, char.ToUpper(theDay.ToString()[0]) + theDay.ToString().Substring(1), true);
                        valid = true;
                    }
                    else if (Convert.ToInt32(wk) == Convert.ToInt32(theDay))
                    {
                        Console.WriteLine("{0} == {1} = {2}", wk, char.ToUpper(theDay.ToString()[0]) + theDay.ToString().Substring(1), true);
                        valid = true;
                    }             
                    else
                    {
                        Console.WriteLine("Today is not {0}. Try again.", char.ToUpper(theDay.ToString()[0]) + theDay.ToString().Substring(1));
                    }
                    
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week:");
                }                    
            }

            //===== HOLD OPEN - till enter is pressed
            Console.ReadLine();
        }
    }
}
