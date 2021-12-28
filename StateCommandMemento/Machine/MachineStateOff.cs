using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Machine
{
    class MachineStateOff : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning Machine On");
        }

        public void Print(string InputText)
        {
            // Om MachineState = Off lägg in InputText i en lista
            Console.WriteLine("Cant print when the machine is off");

        }
    }
}
