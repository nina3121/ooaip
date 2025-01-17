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
        private Mediator _mediator;

        public Calendar(DateOnly date, Mediator mediator)
        {
            this._date = date == null ? throw new ArgumentNullException(nameof(date)) : date;
            _mediator = mediator == null ? throw new ArgumentNullException(nameof(mediator)) : mediator;
        }

        public void MakeRequest()
        {
            CalendarRequest calendarRequest = new CalendarRequest(DateOnly.FromDateTime(DateTime.Now));
            _mediator.Handle(calendarRequest);
        }
    }
}
