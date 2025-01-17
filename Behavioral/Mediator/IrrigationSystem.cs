using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class IrrigationSystem
    {
        public void IrrigationSystemHandler(CalendarRequest request)
        {
            bool IsDayOff = request.IsDayOff();
            if (IsDayOff)
            {
                Console.WriteLine("watering the plants");
            }
        }

        public void IrrigationSystemHandler(AlarmRequest request)
        {
            if (request.Time.Hour % 6 == 0)
            {
                Console.WriteLine("watering the plants");
            }
        }
    }
}
