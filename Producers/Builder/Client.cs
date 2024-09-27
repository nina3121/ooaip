using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Client
    {
        public void OrderBurger()
        {
            BuilderBurger builder = new BuilderBurger();
            var burger = new CheeseBurgerDirector(builder);
            burger.Build();
            MenuBuilder menu = new MenuBuilder();
            List<string> ingredients = menu.Build();
            TestBuilderBurger test = new TestBuilderBurger();
            if (test.Build())
            {
                Console.WriteLine("The burger is cooked correctly ");
            }
            else
            {
                Console.WriteLine("The burger is cooked incorrectly ");
            }
        }
    }
}
