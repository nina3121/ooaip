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

        public void MakeARequest()
        {
            AlarmRequest alarmRequest = new AlarmRequest(new DateTime(2000, 3, 12));
            _mediator.Handle(alarmRequest);
        }

        public void AlarmHandler(IRequest request)
        {
            DateTime time = ((AlarmRequest)request).GetTime();
            Console.WriteLine($"now is {time.Hour} hours");
        }
    }
}
