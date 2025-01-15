using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class CalendarRequest : IRequest
    {
        private DateOnly _date;

        public CalendarRequest(DateOnly date)
        {
            _date = date;   
        }

        public bool IsDayOff()
        {
            return _date.DayOfWeek != DayOfWeek.Saturday && _date.DayOfWeek != DayOfWeek.Sunday;
        }
    }
}
