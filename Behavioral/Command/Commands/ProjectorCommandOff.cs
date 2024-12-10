using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class ProjectorCommandOff : ICommand
    {
        private Projector _projector;

        public ProjectorCommandOff(Projector projector)
        {
            _projector = projector;
        }

        public void Execute()
        {
            _projector.Off();
        }

        public void Undo()
        {
            _projector.On();
        }
    }
}
