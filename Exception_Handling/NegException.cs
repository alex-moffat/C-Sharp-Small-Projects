using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class NegException : Exception     
    {
        public NegException() : base("You can not select a negative number.")
        {
        }
        public NegException(string message) : base(message)
        {
        }
    }
}
