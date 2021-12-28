using Assignment2.StateCommandMemento.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Machine
{
    class MachineMemento
    {
        public Machine1 Machine { get; set; }
        public IMachineState MachineState { get; set; }
        public List<ICommand> CommandList { get; set; }

        public MachineMemento(Machine1 machine, IMachineState machineState, List<ICommand> commands)
        {
            Machine = machine;
            MachineState = machineState;
            CommandList = new List<ICommand>(commands);
        }

        public void Restore()
        {
            Machine.MachineState = MachineState;
            Machine.CommandList = new List<ICommand>(CommandList);
        }
    }
}
