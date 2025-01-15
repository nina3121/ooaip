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
            CalendarRequest calendarRequest = new CalendarRequest(DateOnly.FromDateTime(DateTime.Now));
            mediator.Handle(calendarRequest);
        }
    }
}
