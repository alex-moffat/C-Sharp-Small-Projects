using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    public class Employee : Person, IQuittable
    {
        //===== PROPERTIES
        public int Id { get; set; }

        //===== METHODS
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit(string option = "Sorry to see you go") // this default option will override IQuit default option 
        {
            Console.WriteLine("{0} {1} {2}. \nGood luck in your future endeavors!", option, FirstName, LastName);
        }

    }
}
