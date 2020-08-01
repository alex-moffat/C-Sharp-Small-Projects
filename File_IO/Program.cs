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
                        
            //========== DATETIME - current
            DateTime timeNow = DateTime.Now;
            //----- print to file
            logTxt = string.Format("===== START LOG --> {0}\n", timeNow);
            File.AppendAllText(logFile, logTxt);
            //----- print to screen
            Console.WriteLine("========== STEP 222 ==========");
            Console.WriteLine("Current time: {0}", timeNow);

            //========== USER INPUT
            bool isValid = false;
            int num = 0;
            while (!isValid)
            {
                try
                {
                    Console.WriteLine("Please enter a number:");
                    num = Convert.ToInt32(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oops...something went wrong:");
                    Console.WriteLine(e.Message);
                }
            }

            //========== ADD TIME
            TimeSpan addTime = new TimeSpan(num, 0, 0);
            DateTime futureTime = timeNow.Add(addTime);

            //========== WRITE - to file & console
            logTxt = string.Format("User Selected: {0}", num);
            Console.WriteLine(logTxt);
            using (StreamWriter file = new StreamWriter(logFile, append: true)) file.WriteLine(logTxt);
                        
            logTxt = string.Format("{0} hours from {1} is {2}", num, timeNow, futureTime);
            Console.WriteLine(logTxt);
            using (StreamWriter file = new StreamWriter(logFile, append: true)) file.WriteLine(logTxt);
            
            //========== PRINT - file to screen
            Console.WriteLine(File.ReadAllText(logFile));

            //===== HOLD OPEN - till enter is pressed
            Console.ReadLine();
        }
    }    
}
