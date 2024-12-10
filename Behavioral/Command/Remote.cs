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

            _commandsOn = new ICommand[] {lightCommandOn, teapotCommandOn, commandCollectionOn};
            _commandsOff = new ICommand[] {lightCommandOff, teapotCommandOff, commandCollectionOff};
        }

        public void On(int set)
        {
            switch (set)
            {
                case 1:
                    {
                        _commandsOn[0].Execute();
                        _history.Push(_commandsOn[0]);
                        break;
                    }
                    case 2:
                    {
                        _commandsOn[1].Execute();
                        _history.Push(_commandsOn[1]);
                        break;
                    }
                    case 3:
                    {
                        _commandsOn[2].Execute();
                        _history.Push(_commandsOn[2]);
                        break;
                    }
            }
        }

        public void Off(int set)
        {
            switch (set)
            {
                case 1:
                    {
                        _commandsOff[0].Execute();
                        _history.Push(_commandsOff[0]);
                        break;
                    }
                    case 2:
                    {
                        _commandsOff[1].Execute();
                        _history.Push(_commandsOff[1]);
                        break;
                    }
                    case 3:
                    {
                        _commandsOff[2].Execute();
                        _history.Push(_commandsOff[2]);
                        break;
                    }
            }
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var lastCommand = _history.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("there's no commands");
            }
        }
    }
}
