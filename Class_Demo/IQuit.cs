using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    interface IQuit
    {
        void Quit(string option = "NOT sorry to see you go"); // This option is only used for IQuit objects       
    }
}
