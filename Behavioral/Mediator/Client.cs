using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Client
    {
        public void DoСhores()
        {
            Mediator mediator = new Mediator(); 
            CoffeeMachine machine = new CoffeeMachine();
            Alarm alarm = new Alarm();
            Calendar calendar = new Calendar(new DateOnly(2024, 12, 19));

            CoffeeRequest requestCoffee = new CoffeeRequest(machine, alarm, calendar);
            mediator.Notify(requestCoffee);

            IrrigationSystem irrigationSystem = new IrrigationSystem();
            IrrigationSystemRequest requestIrrigationSystem = new IrrigationSystemRequest(alarm, irrigationSystem);
            mediator.Notify(requestIrrigationSystem);
        }
    }
}
