using Strategy.Cracks;
using Strategy.Ducks;
using Strategy.Flights;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Client
    {
        public void DoSomethingWithDucks()
        {
            var forestDuck = new ForestDuck();
            forestDuck.SetFly(new UsualFly());
            forestDuck.SetCrack(new StandardCrack());

            var mechanicalDuck = new MechanicalDuck();
            mechanicalDuck.SetFly(new RocketFlight());
            mechanicalDuck.SetSwim(new ToSwim());
            mechanicalDuck.SetCrack(new StandardCrack());
        }
    }
}
