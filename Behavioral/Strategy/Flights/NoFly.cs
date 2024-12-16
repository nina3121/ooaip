using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.IStrategy;

namespace Strategy.Flights
{
    public class NoFly : IFly
    {
        public string Fly()
        {
            return "duck can't fly :(";
        }
    }
}
