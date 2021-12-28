using Assignment2.StateCommandMemento.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Machine
{
    class Machine1 : IMachineState
    {
        public IMachineState MachineState { get; set; }
        public List<ICommand> CommandList { get; set; }
        public Machine1()
        {
            MachineState = new MachineStateOff();
            CommandList = new List<ICommand>();
        }

        public MachineMemento CreateMemento()
        {
            MachineMemento savedMemento = new MachineMemento(this, MachineState, CommandList);
            return savedMemento;
        }

        public void PowerSwitch()
        {
            MachineState.PowerSwitch();

            if (MachineState is MachineStateOff)
            {
                MachineState = new MachineStateOn();
                foreach (var item in CommandList)
                {
                    item.Do();
                }
                CommandList.Clear();
            }
            else
            {
                MachineState = new MachineStateOff();
            }
        }

        public void Print(string InputText)
        {
            MachineState.Print(InputText);
            if (MachineState is MachineStateOff)
            {
                MachineCommand newCommand = new MachineCommand(this, InputText);
                CommandList.Add(newCommand);
            }
        }

        //public MachineMemento CreateMemento()
        //{
        //    return new MachineMemento(MachineState);
        //}
    }
}
