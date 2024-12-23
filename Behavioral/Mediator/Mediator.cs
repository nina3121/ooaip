using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Mediator
    {
        private Alarm _alarm;
        private CoffeeMachine _coffeeMachine;
        private Calendar _calendar;
        private IrrigationSystem _irrigationSystem;

        public Mediator(Alarm alarm, CoffeeMachine coffeeMachine, Calendar calendar, IrrigationSystem irrigationSystem)
        {
            _alarm = alarm;
            _coffeeMachine = coffeeMachine;
            _calendar = calendar;
            _irrigationSystem = irrigationSystem;
        }

        public void Notify(string sender)
        {
            
        }
    }
}
