using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class ZeroException : Exception
    {
        public ZeroException() : base("You can not select ZERO.")
        {
        }
        public ZeroException(string message) : base(message)
        {
        }
    }
}
