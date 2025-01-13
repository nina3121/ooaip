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
        public void Notify(IRequest request)
        {
            if (request is IrrigationSystemRequest irrigationSystemRequest)
            {
                irrigationSystemRequest.Alarm.AlarmHandler();
                irrigationSystemRequest.IrrigationSystem.WaterPlants();
            }
            else if (request is CoffeeRequest coffeeMachineRequest)
            {
                coffeeMachineRequest.CoffeeMachine.MakeCoffee();
                coffeeMachineRequest.Alarm.AlarmHandler();
            }
        }
    }
}
