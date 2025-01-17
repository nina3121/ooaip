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
        private IrrigationSystemHandler _irrigationSystem;
        private CoffeeMachineHandler _coffeeMachine;

        public Mediator()
        {
            _irrigationSystem = new IrrigationSystemHandler();
            _coffeeMachine = new CoffeeMachineHandler();
        }

        public void Handle(IRequest request)
        {
            if (request is CalendarRequest calendarRequest)
            {
                _irrigationSystem.Handler(calendarRequest);
            }
            if (request is AlarmRequest alarmRequest)
            {
                _coffeeMachine.Handler(alarmRequest);
                _irrigationSystem.Handler(alarmRequest);
            }
        }
    }
}
