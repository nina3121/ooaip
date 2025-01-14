using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class IrrigationSystem
    {
        public void IrrigationSystemHandler(IRequest request)
        {
            if (((IrrigationSystemRequest)request).GetTime().Hour % 6 == 0 && ((CalendarRequest)request).IsDayOff())
            {
                Console.WriteLine("watering the plants");
            }
        }
    }
}
