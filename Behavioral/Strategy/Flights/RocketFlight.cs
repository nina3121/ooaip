using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.IStrategy;

namespace Strategy.Flights
{
    public class RocketFlight : IFly
    {
        public string Fly()
        {
            return "rocket flight is only for mechanical ducks";
        }
    }
}
