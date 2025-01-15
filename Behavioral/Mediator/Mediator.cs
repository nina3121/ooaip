using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mediator
{
    public class Mediator
    {
        private IrrigationSystem _irrigationSystem;
        private Alarm _alarm;
        private CoffeeMachine _coffeeMachine;
        private Calendar _calendar;

        public Mediator()
        {
            _irrigationSystem = new IrrigationSystem();
            _alarm = new Alarm();
            _coffeeMachine = new CoffeeMachine();
            _calendar = new Calendar(new DateOnly(2002, 12, 19));
        }

        public void Handle(IRequest request)
        {
            if (request is CoffeeRequest coffeeRequest)
            {
                _coffeeMachine.CoffeeHandler(coffeeRequest);
                _alarm.AlarmHandler(coffeeRequest);
            }
            if (request is IrrigationSystemRequest irrigationSystemRequest)
            {
                _calendar.CalendarHandler(irrigationSystemRequest);
                _irrigationSystem.IrrigationSystemHandler(irrigationSystemRequest);
            }
            if (request is AlarmRequest alarmRequest)
            {
                _coffeeMachine.CoffeeHandler(alarmRequest);
            }
        }
    }
}
