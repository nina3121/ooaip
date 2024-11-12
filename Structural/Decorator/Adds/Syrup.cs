using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Adds
{
    public class Syrup : AddComponents
    {
        public Syrup(ICoffee coffee) : base(coffee) { }

        public override double DoCost()
        {
            return 5;
        }
    }
}
