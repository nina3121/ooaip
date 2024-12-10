using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class ProjectorCommandOn : ICommand
    {
        private Projector _projector;

        public ProjectorCommandOn(Projector projector)
        {
            _projector = projector;
        }

        public void Execute()
        {
            _projector.On();
        }

        public void Undo()
        {
            _projector.Off();
        }
    }
}
