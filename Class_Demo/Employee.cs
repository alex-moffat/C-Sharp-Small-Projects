using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    public class Employee : Person
    {
        //===== PROPERTIES
        public int Id { get; set; }

        //===== METHODS
        public override void SayName()
        {
            base.SayName();
        }


    }
}
