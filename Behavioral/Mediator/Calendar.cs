using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Calendar
    {
        private DateOnly _date;

        public Calendar(DateOnly date)
        {
            this._date = date == null ? throw new ArgumentNullException(nameof(date)) : date; ;
        }

        public int CalendarHandler()
        {
            int whichDay = ((int)_date.DayOfWeek == 0 || (int)_date.DayOfWeek == 6) ? 1 : 0;
            return whichDay;
        }
    }
}
