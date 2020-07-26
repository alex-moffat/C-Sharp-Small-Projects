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
        
        //--- SAYNAME - required method from abstract parent class
        public override void SayName()
        {
            base.SayName();
        }
        public override string ReturnName()
        {
            return base.ReturnName();
        }

        //--- Quit - method from override IQuittable
        public void Quit(string option = "Sorry to see you go") // this default option will override IQuittable default option 
        {
            Console.WriteLine("{0} {1} {2}. \nGood luck in your future endeavors!", option, FirstName, LastName);
        }

        //===== OVERLOAD OPERATORS - comparison between employee Ids
        public static bool operator ==(Employee e1, Employee e2)
        {
            bool comparison = e1.Id == e2.Id;
            return comparison;
        }
        public static bool operator !=(Employee e1, Employee e2)
        {
            bool comparison = e1.Id != e2.Id;
            return comparison;
        }
    }
}
