using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Decorator
{
    public abstract class AddComponents : ICoffee 
    {
        protected ICoffee _coffee;

        protected AddComponents(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public abstract double DoCost(); 

        public double Cost() 
        {
            return _coffee.Cost() + this.DoCost();
        }
    }
}
