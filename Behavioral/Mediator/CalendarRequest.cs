using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class CalendarRequest : IRequest
    {
        public DateOnly Date { get; }

        public CalendarRequest(DateOnly date)
        {
            Date = date;   
        }
    }
}
