using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Command.Commands;
using Command.Receivers;

namespace Command
{
    public class Remote
    {
        private readonly ICommand[] _commandsOn;
        private readonly ICommand[] _commandsOff;
        private Stack<ICommand> _history;

        public Remote()
        {
            Light light = new Light();
            Teapot teapot = new Teapot();
            Screen screen = new Screen();
            Projector projector = new Projector();
            Acoustics acoustics = new Acoustics();

            LightCommandOn lightCommandOn = new LightCommandOn(light);
            LightCommandOff lightCommandOff = new LightCommandOff(light);

            TeapotCommandOn teapotCommandOn = new TeapotCommandOn(teapot);
            TeapotCommandOff teapotCommandOff = new TeapotCommandOff(teapot);

            ScreenCommandUp screenCommandUp = new ScreenCommandUp(screen);
            ScreenCommandDown screenCommandDown = new ScreenCommandDown(screen);

            ProjectorCommandOn projectorCommandOn = new ProjectorCommandOn(projector);
            ProjectorCommandOff projectorCommandOff = new ProjectorCommandOff(projector);

            AcousticsCommandOn acousticsCommandOn = new AcousticsCommandOn(acoustics);
            AcousticsCommandOff acousticsCommandOff = new AcousticsCommandOff(acoustics);

            CommandCollectionOn commandCollectionOn = new CommandCollectionOn(lightCommandOn, projectorCommandOn, screenCommandUp, acousticsCommandOn);
            CommandCollectionOff commandCollectionOff = new CommandCollectionOff(lightCommandOff, projectorCommandOff, screenCommandDown, acousticsCommandOff);

            _commandsOn = new ICommand[] { lightCommandOn, teapotCommandOn, commandCollectionOn };
            _commandsOff = new ICommand[] { lightCommandOff, teapotCommandOff, commandCollectionOff };
        }

        public void On(int set)
        {
            _commandsOn[set].Execute();
            _history.Push(_commandsOff[set]);
        }

        public void Off(int set)
        {
            _commandsOff[set].Execute();
            _history.Push(_commandsOn[set]);
        }
    }
}
