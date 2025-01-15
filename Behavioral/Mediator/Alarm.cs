using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mediator
{
    public class Alarm
    {
        private Mediator _mediator;

        public Alarm(Mediator mediator)
        {
            _mediator = mediator == null ? throw new ArgumentNullException(nameof(mediator)) : mediator;
        }

        public void MakeARequest()
        {
            AlarmRequest alarmRequest = new AlarmRequest(DateTime.Now);
            _mediator.Handle(alarmRequest);
        }
    }
}
