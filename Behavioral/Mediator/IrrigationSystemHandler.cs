using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class IrrigationSystemHandler
    {
        public bool IsDayOff { get; set; }
        
        public void Handler(CalendarRequest request)
        {
            IsDayOff = request.Date.DayOfWeek != DayOfWeek.Saturday && request.Date.DayOfWeek != DayOfWeek.Sunday;
            if (IsDayOff)
            {
                Console.WriteLine("watering the plants");
            }
        }

        public void Handler(AlarmRequest request)
        {
            if (request.Time.Hour % 6 == 0)
            {
                Console.WriteLine("watering the plants");
            }
        }
    }
}
