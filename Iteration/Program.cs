using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {


            //=============== EXAMPLES ===============
            
            //----- ARRAY - integer
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            for (int i = 0; i < testScores.Length; i++) 
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }
            
            //----- ARRAY - string
            string[] names = { "Alex", "Zan", "Lisa", "Grace", "Albert", "Zuli", "Burbus", "Plurp", "Peep" };
            for (int n = 0; n < names.Length; n++)
            {
                if (names[n].Contains("a"))
                {
                    Console.WriteLine("Name: " + names[n]);
                }
            }

            //----- List - integer
            List<int> scores = new List<int>();
            scores.Add(98);
            scores.Add(99);
            scores.Add(81);
            scores.Add(72);
            scores.Add(70);
            scores.Add(91);
            scores.Add(86);
            scores.Sort();
            List<int> passingScores = new List<int>();
            foreach(int s in scores)
            {
                if (s >85)
                {
                    passingScores.Add(s);
                    Console.WriteLine("Passing score: " + s);
                }
                else
                {
                    Console.WriteLine("Failing score: " + s);
                }
            }
            Console.WriteLine("Number of passing scores: " + passingScores.Count);
            
            //----- List - string
            List<string> nameList = new List<string>() { "Alex", "Zan", "Lisa", "Grace", "Albert", "Zuli", "Burbus", "Plurp", "Peep" };
            foreach (string n in nameList)
            {
                if (n.Contains("e"))
                {
                    Console.WriteLine("Name: " + n);
                }
            }

            //===== HOLD OPEN - till enter is pressed
            Console.ReadLine();
        }
    }
}
