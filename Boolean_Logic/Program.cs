using System;

namespace Boolean_Logic
{
    class Program
    {
        static void Main()
        {
            //===== INPUTS
            Console.WriteLine("=== Car Insurance Approval Check ===");
            Console.WriteLine("What is your age?");
            ushort iAge = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI (true/false)?");
            bool iDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            ushort iTickets = Convert.ToUInt16(Console.ReadLine());
            //===== DECISION
            Console.WriteLine("Qualified?\n{0}", (iAge>15 && iDUI != true && iTickets <= 3));


            //========== EXAMPLES
            //Console.WriteLine("===== Boolean AND");
            //Console.WriteLine(false && false);
            //Console.WriteLine(true && false);
            //Console.WriteLine(false && true);
            //Console.WriteLine(true && true);
            //Console.WriteLine("===== Boolean OR");
            //Console.WriteLine(false || false);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || true);
            //Console.WriteLine(true || true);
            //Console.WriteLine("===== Boolean ==");
            //Console.WriteLine(false == false);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == true);
            //Console.WriteLine(true == true);
            //Console.WriteLine("===== Boolean !=");
            //Console.WriteLine(false != false);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != true);
            //Console.WriteLine(true != true);
            //// evaluates to true if one or the other are true but not both
            //Console.WriteLine("===== Boolean ^");
            //Console.WriteLine(false ^ false);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ true);
            //Console.WriteLine(true ^ true);
            //Console.WriteLine("===== Boolean multiples on one line");
            //Console.WriteLine(false || true && true);
            //Console.WriteLine(false || true ^ false);
            //Console.WriteLine(false && false ^ true);
            //Console.WriteLine(true && true && true || false);

            //===== HOLD OPEN - till enter is pressed
            Console.ReadLine();
        }
    }
}
