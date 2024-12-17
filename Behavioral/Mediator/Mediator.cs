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

        private bool _isWeekday = true;
        
        public void SetAlarm(Alarm alarm) => _alarm = alarm;

        public void SetCoffeeMachine(CoffeeMachine coffee) => _coffeeMachine = coffee;

        public void SetCalendar(Calendar calendar) => _calendar = calendar;

        public void SetIrrigationSystem(IrrigationSystem irrigation) => _irrigationSystem = irrigation;

        public void Notify(string sender, int data)
        {
            if (sender == "Calendar")
            {
                _isWeekday = data == 0;
            }
            else if (sender == "Alarm")
            {
                if (data == 8 && _isWeekday)
                {
                    _coffeeMachine.MakeCoffee();
                }
                if (data % 6 == 0)
                {
                    _irrigationSystem.WaterPlants();
                }
            }
        }
    }
}
