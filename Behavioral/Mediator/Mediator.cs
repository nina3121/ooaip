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
        private CoffeeMachine _coffeeMachine;

        public Mediator()
        {
            _irrigationSystem = new IrrigationSystem();
            _coffeeMachine = new CoffeeMachine();
        }

        public void Handle(IRequest request)
        {
            if (request is CalendarRequest calendarRequest)
            {
                _irrigationSystem.IrrigationSystemHandler(calendarRequest);
            }
            if (request is AlarmRequest alarmRequest)
            {
                _coffeeMachine.CoffeeHandler(alarmRequest);
            }
        }
    }
}
