using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Console_App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //===== ARRAY - movies
            Console.WriteLine("===== ARRAY");
            string[] movies = { "Black Panther (2018)", "Avengers: Endgame (2019)", "Us (2019)", "Toy Story 4 (2019)", "The Wizard of Oz (1939)", "Mission: Impossible - Fallout (2018)", "Lady Bird (2017)", "Citizen Kane (1941)", "The Irishman (2019)", "BlacKkKlansman (2018)" };
            //===== USER INPUT
            Console.WriteLine("Please enter some text to be added to a list of movies:");
            string userText = Console.ReadLine();
            //===== ITERATIONS - add user input to each item in array, print each item in array on seperate line
            for (int i=0; i < movies.Length; i++)
            {
                movies[i] = movies[i] + userText;
            }
            foreach (string m in movies)
            {
                Console.WriteLine(m);
            }
            //===== INFINITE LOOPS
            Console.WriteLine("\n===== LOOPS");
            bool fix = false;
            int loopCount = 0;
            while (!fix)
            {
                if (loopCount < int.MaxValue/100000000)
                {
                    loopCount++;
                    Console.WriteLine("Infinite loop on loop number: " + loopCount);                    
                }
                else
                {
                    fix = true;
                    Console.WriteLine("Applied fix: Infinite loop stopped at {0} loops", loopCount);
                }                
            }
            fix = false;
            loopCount = 0;
            while (!fix)
            {
                if (loopCount <= int.MaxValue / 100000000)
                {
                    loopCount++;
                    Console.WriteLine("Infinite loop on loop number: " + loopCount);
                }
                else
                {
                    fix = true;
                    Console.WriteLine("Applied fix: Infinite loop stopped at {0} loops", loopCount);
                }
            }

            //===== LIST - pets
            Console.WriteLine("\n===== LIST - pets");
            //--- variables
            bool onList;
            bool valid = false;
            string cont, userSelect;
            List<string> pets = new List<string>() { "Albert", "Zuli", "Barbus", "Plurp", "Peep", "Nug", "Pillar", "Batman", "Papaya", "Supreme", "Gucci" };
            //--- Print pet list
            Console.WriteLine("\nMOFFAT FAMILY FARM:");
            foreach (string p in pets)
            {
                Console.WriteLine(p);
            }
            //--- get user input
            while (!valid)
            {
                Console.WriteLine("\nSelect a pet name to print the index of:");
                userSelect = Console.ReadLine().ToLower();
                //--- check user selection in list using Exists method
                onList = pets.Exists(x => x.ToLower() == userSelect);
                if (onList) //--- print index of user select
                {
                    valid = true;
                    for (int i = 0; i < pets.Count; i++)
                    {
                        if (userSelect == pets[i].ToLower())
                        {
                            Console.WriteLine("The index of name you selected is " + i);
                            break;
                        }
                    }
                }
                else //--- user selection not in list, check if user wants to try again
                {
                    Console.WriteLine("You did not pick a pet name from the Moffat Family Farm");
                    Console.WriteLine("Do you want to try again (y/n)?");
                    cont = Console.ReadLine().ToLower();
                    if (cont == "n" || cont == "no") { valid = true; }
                }                       
            }

            //===== LIST - words
            Console.WriteLine("\n===== LIST - words");
            //--- variables
            List<string> words = new List<string>() { "tree", "house", "bush", "grass", "house", "tree", "lake", "stream", "pond", "mountain", "road", "bush", "stream", "river", "lake", "house" };
            List<string> dupWords = new List<string>();
            StringBuilder indices = new StringBuilder();
            //--- iterate through list, find duplicates on list, create printable list
            StringBuilder wordsDisplay = new StringBuilder("[");
            foreach (string w in words)
            {
                wordsDisplay.Append(" " + w + ",");
                if (dupWords.Exists(x => x == w))
                {
                    Console.WriteLine(w + " has already appeared in the list");
                }
                else
                {
                    dupWords.Add(w);
                    Console.WriteLine(w + " has NOT appeared in the list before");
                }
            }
            wordsDisplay.Length = (wordsDisplay.Length - 1);
            wordsDisplay.Append(" ]");
            Console.WriteLine("\nWORDS LIST:\n" + wordsDisplay);
            //--- get user input 
            valid = false;
            while (!valid)
            {
                Console.WriteLine("\nSelect a word from the list to print the indices of occurance:");
                userSelect = Console.ReadLine().ToLower();
                //--- check user selection in list using Exists method
                onList = words.Exists(x => x.ToLower() == userSelect);
                if (onList) //--- print indices of user selection
                {
                    valid = true;
                    for (int i = 0; i < words.Count; i++)
                    {
                        if (userSelect == words[i].ToLower())
                        {
                            indices.Append(i + ", ");                            
                        }
                    }
                    indices.Length = (indices.Length - 2);
                    Console.WriteLine("The word \"{0}\" occurs in the list at index: {1}", userSelect, indices);
                }
                else //--- user selection not in list, check if user wants to try again
                {
                    Console.WriteLine("You did not pick a word from the list.");
                    Console.WriteLine("Do you want to try again (y/n)?");
                    cont = Console.ReadLine().ToLower();
                    if (cont == "n" || cont == "no") { valid = true; }
                }
            }

            //===== HOLD OPEN - till enter is pressed
            Console.ReadLine();
        }
    }
}
