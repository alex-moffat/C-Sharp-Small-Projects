using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //===== VARIABLES
            string compare = "";
            ushort times = 0;
            Random rnd = new Random();
            ushort targetNum = Convert.ToUInt16(rnd.Next(1, 101));
            bool correct = false;

            Console.WriteLine("===== A RANDOM NUMBER HAS BEEN SELECTED =====");
            Console.WriteLine("Guess a number from 1 to 100:");
            ushort guessNum = Convert.ToUInt16(Console.ReadLine());
            ushort target2 = (guessNum == targetNum) ? Convert.ToUInt16(rnd.Next(1, 101)) : guessNum; // round 2 number set here
            
            //===== DO WHILE - performs before the while condition is evaluated
            do
            {
                times += 1;
                if (guessNum == targetNum)
                {
                    Console.WriteLine("Number {0} is correct! It only took you {1} guesses.\n", guessNum, times);
                    correct = true;
                }
                else
                {
                    compare = guessNum > targetNum ? "greater" : "less";
                    Console.WriteLine("You guessed number {0} which is {1} than the correct number. Guess again.\n", guessNum, compare);
                    Console.WriteLine("Guess a number from 1 to 100:");
                    guessNum = Convert.ToUInt16(Console.ReadLine());
                }
            }
            while (!correct);

            //===== WHILE - performs action after the while condition is evaluated
            targetNum = target2;
            Console.WriteLine("===== A NEW NUMBER HAS BEEN SELECTED =====");
            correct = false;
            times = 0;
            while (!correct)
            {
                times += 1;
                Console.WriteLine("Guess a number from 1 to 100:");
                guessNum = Convert.ToUInt16(Console.ReadLine());
                if (guessNum == targetNum)
                {
                    Console.WriteLine("Number {0} is correct! It only took you {1} guesses.", guessNum, times);
                    correct = true;
                }
                else
                {
                    compare = guessNum > targetNum ? "greater" : "less";
                    Console.WriteLine("You guessed number {0} which is {1} than the correct number. Guess again.\n", guessNum, compare);
                }
            }
            



            //=============== EXAMPLES ===============

            ////===== WHILE - performs action after the while condition is evaluated
            //ushort gNum = 0;
            //bool isGuessed = false;
            //while  (!isGuessed)
            //{
            //    Console.WriteLine("Guess a number from 1 to 100:");
            //    gNum = Convert.ToUInt16(Console.ReadLine());
            //    switch (gNum)
            //    {
            //        case 12:
            //            Console.WriteLine("You guessed number {0}. That is correct!", gNum);
            //            isGuessed = true;
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed number {0}. Try again.\n", gNum);
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed number {0}. Try again.\n", gNum);
            //            break;
            //        case 62:
            //            Console.WriteLine("You guessed number {0}. Try again.\n", gNum);
            //            break;
            //        default:
            //            Console.WriteLine("You are just plain wrong!\n", gNum);
            //            break;
            //    }                
            //}
            ////===== DO WHILE - performs action before the while condition is evaluated
            //Console.WriteLine("Guess a number from 1 to 100:");
            //gNum = Convert.ToUInt16(Console.ReadLine());
            //isGuessed = gNum == 12;
            //do
            //{
            //    switch (gNum)
            //    {
            //        case 12:
            //            Console.WriteLine("You guessed number {0}. That is correct!", gNum);
            //            isGuessed = true;
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed number {0}. Try again.\n", gNum);
            //            Console.WriteLine("Guess a number from 1 to 100:");
            //            gNum = Convert.ToUInt16(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed number {0}. Try again.\n", gNum);
            //            Console.WriteLine("Guess a number from 1 to 100:");
            //            gNum = Convert.ToUInt16(Console.ReadLine());
            //            break;
            //        case 62:
            //            Console.WriteLine("You guessed number {0}. Try again.\n", gNum);
            //            Console.WriteLine("Guess a number from 1 to 100:");
            //            gNum = Convert.ToUInt16(Console.ReadLine());
            //            break;
            //        default:
            //            Console.WriteLine("You are just plain wrong!\n", gNum);
            //            Console.WriteLine("Guess a number from 1 to 100:");
            //            gNum = Convert.ToUInt16(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!isGuessed);

            //===== HOLD - console open till enter pressed
            Console.ReadLine();
        }
    }
}
