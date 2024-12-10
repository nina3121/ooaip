using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class AcousticsCommandOn : ICommand
    {
        private Acoustics _acoustics;

        public AcousticsCommandOn(Acoustics acoustics)
        {
            _acoustics = acoustics;
        }

        public void Execute()
        {
            _acoustics.On();
        }

        public void Undo()
        {
            _acoustics.Off();
        }
    }
}
