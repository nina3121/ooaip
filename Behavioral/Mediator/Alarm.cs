using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Alarm
    {
        private Mediator _mediator;

        public Alarm(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void AlarmHandler()
        {
            for (int i = 0; i < 24; i++)
            {
                Console.WriteLine($"now is {i} hours");
                _mediator.Notify("Alarm");
            }
        }
    }
}
