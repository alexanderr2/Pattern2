using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Machine
{
    class MachineStateOn : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning Machine Off");
        }

        public void Print(string InputText)
        {
            // Om MachineState = On kolla i listan och printa ut alla InputText
            Console.WriteLine(InputText);

        }
    }
}
