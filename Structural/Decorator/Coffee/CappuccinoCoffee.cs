using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Coffee
{
    public class CappuccinoCoffee : ICoffee
    {
        public double Cost()
        {
            return 20;
        }
    }
}
