using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class CommandCollectionOnOff : ICommand
    {
        private readonly ICommand[] _commandsOff;

        public CommandCollectionOnOff(ICommand[] commands)
        {
            _commandsOff = commands;
        }

        public void Execute()
        {
            foreach (var command in _commandsOff)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _commandsOff)
            {
                command.Undo();
            }
        }
    }
}
