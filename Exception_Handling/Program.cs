using System;
using System.Collections.Generic;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {


            //=============== EXAMPLES ===============
            List<int> numbers = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            try
            {
                Console.WriteLine("Pick a number to divide a list of numbers by:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                foreach (int n in numbers)
                {
                    Console.WriteLine(n / num1);
                }                
            }
            catch (FormatException e)
            {
                Console.WriteLine("Make sure to select a whole number");
                Console.WriteLine(e.Message);
                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Please don't divide by zero");
                Console.WriteLine(e.Message);
                
            }
            catch (Exception e)
            {
                //----- this will trigger if you enter a number too large for integer
                Console.WriteLine("Oops...something went wrong");
                Console.WriteLine(e.Message);                
            }
            finally 
            {
                Console.WriteLine("\nfinally triggered...Log something to a DB etc.");
            }
            Console.WriteLine("Emerged from the try/catch block");
            
            //===== HOLD OPEN - till enter is pressed
            Console.ReadLine();
        }
    }
}
