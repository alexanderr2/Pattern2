using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Command
{
    class CommandManager
    {
        public List<ICommand> CommandList { get; set; }

        public CommandManager()
        {
            CommandList = new List<ICommand>();
        }



    }
}
