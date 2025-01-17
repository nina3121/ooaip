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

        public Calendar(Mediator mediator)
        {
            _mediator = mediator == null ? throw new ArgumentNullException(nameof(mediator)) : mediator;
        }

        public void MakeRequest()
        {
            CalendarRequest calendarRequest = new CalendarRequest(DateOnly.FromDateTime(DateTime.Now));
            _mediator.Handle(calendarRequest);
        }
    }
}
