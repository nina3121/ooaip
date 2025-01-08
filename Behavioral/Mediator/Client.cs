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
            CoffeeMachine machine = new CoffeeMachine();
            Alarm alarm = new Alarm();
            Calendar calendar = new Calendar(new DateOnly(2024, 12, 19));

            RequestCoffee requestCoffee = new RequestCoffee(machine, alarm, calendar);
            requestCoffee.Execute();

            IrrigationSystem irrigationSystem = new IrrigationSystem();
            RequestIrrigationSystem requestIrrigationSystem = new RequestIrrigationSystem(alarm, irrigationSystem);
            requestIrrigationSystem.Execute();  
        }
    }
}
