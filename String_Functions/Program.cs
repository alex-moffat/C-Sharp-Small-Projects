using Microsoft.SqlServer.Server;
using System;
using System.Security.AccessControl;
using System.Text;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //===== STARTING STRINGS
            string t = "primary key\n";
            string s1 = "a table can have one primary key,\n";
            string s2 = "it should be unique for each row.\n";
            string s3 = "on one or many columns it might be,\n";
            string s4 = "two a composite key you know.\n";
            string stanza1 = (char.ToUpper(s1[0]) + s1.Substring(1)) + s2 + (char.ToUpper(s3[0]) + s3.Substring(1)) + s4;
            string[] stanza2 = { "A row can be identified by it,", "a telephone number of kind.", "A fine way to get data I admit,", "the correct data it will find." };
            string[] stanza3 = { "A primary key must never be null,", "it's there so it must be legit.", "A modest integer field might seem dull,", "but I don't see a better fit." };

            StringBuilder poem = new StringBuilder();
            poem.Append(t.ToUpper() + "\n" + stanza1 + "\n");
            foreach (string i in stanza2)
            {
                poem.Append(String.Format("{0}\n", i));
            }
            poem.Append("\n");
            foreach (string i in stanza3)
            {
                poem.Append(String.Format("{0}\n", i));
            }
            poem.Append("\n-SpaceJoe");
            Console.WriteLine(poem);

            ////=============== EXAMPLES ===============
            //string name = "Alex";
            //string filepath = "C:\\users\\Alex";
            //string desktop = @"C:\Users\Alexander\Desktop"; // no escape characters are needed in a string followed by @

            //string quote = String.Format("My name is \"{0}\".\nThank you for checking my demo.\n\tHello on a tab.\nMy filepath is\t\t{1}\nMy desktop path is\t{2}", name.ToUpper(), filepath, desktop);
            //Console.WriteLine(quote);

            //bool tf1 = name.Contains("X");
            //bool tf2 = name.Contains("x");
            //bool tf3 = name.EndsWith("X");
            //bool tf4 = name.EndsWith("x");
            //bool tf5 = name.StartsWith("a");
            //bool tf6 = name.StartsWith("A");
            //int deskLength = desktop.Length;
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", tf1,tf2,tf3,tf4,tf5,tf6,deskLength,name.ToLower());
            
            ////===== STRING BUILDER
            //StringBuilder sb = new StringBuilder();
            //sb.Append("My full name is ");
            //sb.Append(name + " Moffat");
            //Console.WriteLine(sb);


            //===== HOLD OPEN - till enter is pressed
            Console.ReadLine();
        }
    }
}
