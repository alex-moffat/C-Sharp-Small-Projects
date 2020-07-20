using System;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            //----- GREETING
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            //----- NAME
            Console.WriteLine("\nWhat is your name?");
            string iName = Console.ReadLine();
            //----- COURSE
            Console.WriteLine("\nWhat course are you on?");
            string iCourse = Console.ReadLine();
            //----- PAGE
            Console.WriteLine("\nWhat page number?");
            ushort iPage = Convert.ToUInt16(Console.ReadLine());
            //----- HELP
            Console.WriteLine("\nDo you need help with anything? Please answer only \"true\" or \"false\".");
            bool iHelp = Convert.ToBoolean(Console.ReadLine());
            //----- POSITIVE
            Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.");
            string iPositive = Console.ReadLine();
            //----- FEEDBACK
            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
            string iFeedback = Console.ReadLine();
            //----- HOURS
            Console.WriteLine("\nHow many hours did you study today?");
            float iHours = float.Parse(Console.ReadLine());
            //----- EXIT
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            //Console.WriteLine(iName + "\n" + iCourse + "\n" + iPage + "\n" + iHelp + "\n" + iPositive + "\n" + iFeedback + "\n" + iHours);
            Console.ReadLine();
        }
    }
}
