using Assignment2.StateCommandMemento.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    class MachineCommand : ICommand
    {
        // Gör en ny Machine med typen Machine1
        public Machine1 Machine { get; set; }
        // Prop för vad för typ av värde som skickas(?)
        public string InputText { get; set; }

        public MachineCommand(Machine1 machine, string inputText)
        {
            Machine = machine;
            InputText = inputText;
        }
        
        // Funktion som kallar på Machine's Print funktion och skickar med InputText
        public void Do()
        {
            Machine.Print(InputText);
        }
    }
}
