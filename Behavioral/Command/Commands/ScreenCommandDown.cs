using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class ScreenCommandDown : ICommand
    {
        private Screen _screen;

        public ScreenCommandDown(Screen screen)
        {
            _screen = screen;
        }

        public void Execute()
        {
            _screen.Down();
        }

        public void Undo()
        {
            _screen.Up();
        }
    }
}
