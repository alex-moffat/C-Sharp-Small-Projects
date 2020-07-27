using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    public class Employee<T> : Person, IQuittable
    {
        //===== PROPERTIES
        public List<T> Things = new List<T>();
        public int Id { get; set; }


        //===== METHODS

        //--- SAYTHINGS - write each item from Things  
        public void SayThings()
        {
            foreach (T thing in Things)
            {
                Console.WriteLine(thing);
            }
        }
        //--- RETURN THINGS - return a each item from Things, one on each line 
        public string ReturnThings(bool newline = true)
        {
            string value = "";
            foreach (T thing in Things)
            {
                value += (newline) ? String.Format("{0}\n", thing) : String.Format("{0}, ", thing);
            }
            if (!newline) { value = value.Remove(value.Length - 2, 2); }
            return value;
        }

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
        public static bool operator ==(Employee<T> e1, Employee<T> e2)
        {
            bool comparison = e1.Id == e2.Id;
            return comparison;
        }
        public static bool operator !=(Employee<T> e1, Employee<T> e2)
        {
            bool comparison = e1.Id != e2.Id;
            return comparison;
        }
    }
}
