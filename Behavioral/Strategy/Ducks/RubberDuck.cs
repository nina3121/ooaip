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
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new NoFly(), new ToSwim(), new CrackOfRubberDuck()) { }
    }
}
