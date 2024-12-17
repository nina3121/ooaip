using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Calendar
    {
        private Mediator _mediator;
        private DateTime _date;

        public Calendar(Mediator mediator, DateTime date)
        {
            this._mediator = mediator;
            this._date = date;
        }

        public void CalendarHandler()
        {
            int whichDay = ((int)_date.DayOfWeek == 0 || (int)_date.DayOfWeek == 6) ? 1 : 0;
            _mediator.Notify("Calendar", whichDay);
        }
    }
}
