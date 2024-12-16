using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class CommandCollectionOn : ICommand
    {
        private readonly ICommand[] _commandsOn;
        private LightCommandOn _light;
        private ProjectorCommandOn _projector;
        private ScreenCommandUp _screen;
        private AcousticsCommandOn _acoustics;

        public CommandCollectionOn(LightCommandOn light, ProjectorCommandOn projector, ScreenCommandUp screen, AcousticsCommandOn acoustics)
        {
            if (light == null || projector == null || screen == null || acoustics == null)
            {
                throw new ArgumentNullException();
            }
            _light = light;
            _projector = projector;
            _screen = screen;
            _acoustics = acoustics;
            commandsOn = new ICommand[] { light, projector, screen, acoustics };
        }

        public void Execute()
        {
            foreach (var command in commandsOn)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in commandsOn)
            {
                command.Undo();
            }
        }
    }
}
