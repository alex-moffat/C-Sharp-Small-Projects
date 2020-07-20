using System;

namespace Income_Comparison
{
    class Program
    {
        static void Main()
        {
            //===== HEADER
            Console.WriteLine("Anonymous Income Comparison Program");
            //===== PERSON 1
            Console.WriteLine("\nPerson 1:");
            Console.WriteLine("Hourly Rate?");
            float hr1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float hw1 = float.Parse(Console.ReadLine());
            int s1 = Convert.ToInt32(hr1 * hw1 * 52);
            //===== PERSON 2
            Console.WriteLine("\nPerson 2:");
            Console.WriteLine("Hourly Rate?");
            float hr2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float hw2 = float.Parse(Console.ReadLine());
            int s2 = Convert.ToInt32(hr2 * hw2 * 52);
            //===== ANNUAL SALARIES
            Console.WriteLine("\nAnnual salary of Person 1:\n{0:n0}",s1);
            Console.WriteLine("\nAnnual salary of Person 2:\n{0:n0}",s2);
            bool sCompare = s1 > s2;
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?\n" + sCompare);
            //===== HOLD - console open till enter pressed
            Console.ReadLine();
        }
    }
}
