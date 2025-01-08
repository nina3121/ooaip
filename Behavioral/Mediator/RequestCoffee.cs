using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class RequestCoffee : IRequest
    {
        private CoffeeMachine _machine;
        private Alarm _alarm;
        private Calendar _calendar;

        public RequestCoffee(CoffeeMachine machine, Alarm alarm, Calendar calendar)
        {
            _machine = machine == null ? throw new ArgumentNullException(nameof(machine)) : machine;
            _alarm = alarm == null ? throw new ArgumentNullException(nameof(alarm)) : alarm;
            _calendar = calendar == null ? throw new ArgumentNullException(nameof(calendar)) : calendar;
        }

        public void Execute()
        {
            if (_calendar.CalendarHandler() == 0)
            {
                _machine.MakeCoffee();
                _alarm.AlarmHandler();
            }
        }
    }
}
