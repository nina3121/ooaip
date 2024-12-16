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
    public class ForestDuck : Duck
    {
        public ForestDuck() : base(new UsualFly(), new ToSwim(), new StandardCrack()) { }
    }
}
