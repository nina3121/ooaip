using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class AlarmRequest : IRequest
    {
        private DateTime _time;

        public AlarmRequest(DateTime time)
        {
            _time = time;
        }

        public DateTime GetTime()
        {
            return _time;
        }
    }
}
