using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Client
    {
        public void Run()
        {
            BurgerBuilder burger = CheeseBurger.Instance;
            BurgerDirector director = new BurgerDirector();
            director.SetBurger(burger);
            director.GetCookedBurger();
            Burger cookedBurger = burger.GetBurger();
            List<string> ingredients = cookedBurger.GetIngredients();
        }
    }
}
