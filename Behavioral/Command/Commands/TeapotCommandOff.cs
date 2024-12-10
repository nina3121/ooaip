using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class TeapotCommandOff : ICommand
    {
        private Teapot _teapot;

        public TeapotCommandOff(Teapot teapot)
        {
            _teapot = teapot;
        }

        public void Execute()
        {
            _teapot.Off();
        }

        public void Undo()
        {
            _teapot.On();
        }
    }
}
