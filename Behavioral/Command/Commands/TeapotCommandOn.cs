using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class TeapotCommandOn : ICommand
    {
        private Teapot _teapot;

        public TeapotCommandOn(Teapot teapot)
        {
            _teapot = teapot;
        }

        public void Execute()
        {
            _teapot.On();
        }

        public void Undo()
        {
            _teapot.Off();
        }
    }
}
