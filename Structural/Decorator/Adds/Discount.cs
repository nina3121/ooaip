using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Adds
{
    public class Discount : AddComponents
    {
        public Discount(ICoffee coffee) : base(coffee) { }

        public override double DoCost()
        {
            return -_coffee.Cost() * 0.05;
        }
    }
}
