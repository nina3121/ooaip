using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class ScreenCommandUp : ICommand
    {
        private Screen _screen;

        public ScreenCommandUp(Screen screen)
        {
            _screen = screen;
        }

        public void Execute()
        {
            _screen.Up();
        }

        public void Undo()
        {
            _screen.Down();
        }
    }
}
