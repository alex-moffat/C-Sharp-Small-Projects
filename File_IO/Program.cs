using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //===== CONSOLE COLOR
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //========== LOG FILE
            string logTxt = "========== File_IO LOG ==========\n";
            string logDir = Directory.GetCurrentDirectory() + @"\logs";
            string logFile = logDir + @"\log.txt";
            if (!Directory.Exists(logDir))
            {
                Directory.CreateDirectory(logDir);                
                File.WriteAllText(logFile, logTxt);
            }
            
            //========== USER INPUT
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    Console.WriteLine("Please enter a number:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    logTxt = num.ToString();
                    isValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oops...something went wrong:");
                    Console.WriteLine(e.Message);
                }
            }

            //========== WRITE TO FILE
            //--- method 1
            using (StreamWriter file = new StreamWriter(logFile, append: true))
            {
                file.WriteLine(logTxt);
            }
            //--- method 2
            File.AppendAllText(logFile, logTxt);

            //========== WRITE TO FILE
            Console.WriteLine(File.ReadAllText(logFile));

            //===== HOLD OPEN - till enter is pressed
            Console.ReadLine();
        }
    }    
}
