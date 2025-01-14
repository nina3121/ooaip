using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class IrrigationSystemRequest : IRequest
    {
        private TimeOnly _time;

        public IrrigationSystemRequest(TimeOnly time)
        {
            _time = time;
        }

        public TimeOnly GetTime()
        {
            return _time;
        }
    }
}
