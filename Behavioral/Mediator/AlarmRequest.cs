using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class AlarmRequest : IRequest
    {
        public TimeOnly Time { get; }

        public AlarmRequest(TimeOnly time)
        {
            Time = time;
        }
    }
}
