using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class CommandCollectionOff : ICommand
    {
        private readonly ICommand[] _commandsOff;
        private LightCommandOff _light;
        private ProjectorCommandOff _projector;
        private ScreenCommandDown _screen;
        private AcousticsCommandOff _acoustics;

        public CommandCollectionOff(LightCommandOff light, ProjectorCommandOff projector, ScreenCommandDown screen, AcousticsCommandOff acoustics)
        {
            if (light == null || projector == null || screen == null || acoustics == null)
            {
                throw new ArgumentNullException();
            }
            _light = light;
            _projector = projector;
            _screen = screen;
            _acoustics = acoustics;
            commandsOff = new ICommand[] { light, projector, screen, acoustics };
        }

        public void Execute()
        {
            foreach (var command in commandsOff)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in commandsOff)
            {
                command.Undo();
            }
        }
    }
}
