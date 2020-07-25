using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    public class Person
    {
        //===== PROPERTIES
        public string FirstName, LastName;

        //===== METHODS
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}.", FirstName, LastName);
        }
    }
}
