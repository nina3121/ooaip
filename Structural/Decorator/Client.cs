using Decorator.Adds;
using Decorator.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Client
    {
        public void GetCoffee()
        {
            ICoffee cappuccino = new CappuccinoCoffee();
            cappuccino = new Syrup(cappuccino);
            cappuccino = new Marshmallows(cappuccino);

            ICoffee latte = new LatteCoffee();
            latte = new Cinnamon(latte);
            latte = new Discount(latte);
            Console.WriteLine(latte.Cost());
        }
    }
}
