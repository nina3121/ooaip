using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class AcousticsCommandOff : ICommand
    {
        private Acoustics _acoustics;

        public AcousticsCommandOff(Acoustics acoustics)
        {
            _acoustics = acoustics;
        }

        public void Execute()
        {
            _acoustics.Off();
        }

        public void Undo()
        {
            _acoustics.On();
        }
    }
}
