using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Coffee
{
    public class LatteCoffee : ICoffee
    {
        public double Cost()
        {
            return 15;
        }
    }
}
