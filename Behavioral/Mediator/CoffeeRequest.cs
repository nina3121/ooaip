using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class CoffeeRequest : IRequest
    {
        private CoffeeMachine _machine;
        private Alarm _alarm;
        private Calendar _calendar;

        public CoffeeRequest(CoffeeMachine machine, Alarm alarm, Calendar calendar)
        {
            _machine = machine == null ? throw new ArgumentNullException(nameof(machine)) : machine;
            _alarm = alarm == null ? throw new ArgumentNullException(nameof(alarm)) : alarm;
            _calendar = calendar == null ? throw new ArgumentNullException(nameof(calendar)) : calendar;
        }

        public CoffeeMachine CoffeeMachine => _machine;
        public Alarm Alarm => _alarm;
        public Calendar Calendar => _calendar;
    }
}
