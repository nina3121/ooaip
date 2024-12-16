using Strategy.Cracks;
using Strategy.Flights;
using Strategy.IStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    public class MechanicalDuck : Duck
    {
        public MechanicalDuck() : base(new RocketFlight(), new ToSwim(), new StandardCrack()) { }
    }
}
