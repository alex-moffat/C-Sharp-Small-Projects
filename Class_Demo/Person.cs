using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    public abstract class Person
    {
        //===== PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //===== METHODS
        public virtual void SayName()
        {
            Console.WriteLine("Name: {0} {1}.", FirstName, LastName);
        }
        public virtual string ReturnName()
        {
            string str = this.FirstName + " " + this.LastName;
            return str;
        }
    }
}
