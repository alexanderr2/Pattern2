using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Machine
{
    class MachineStatePrinting : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Cant turn off while printing");
        }

        public void Print(string InputText)
        {
            Console.WriteLine("Printing");
        }
    }
}
