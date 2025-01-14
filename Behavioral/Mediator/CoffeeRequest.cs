using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class CoffeeRequest : IRequest
    {
        private TimeOnly _time;

        public CoffeeRequest(TimeOnly time)
        {
            _time = time;
        }

        public TimeOnly GetTime()
        {
            return _time;    
        }
    }
}
