using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class BurgerDirector
    {
        private BurgerBuilder _burger;
        public void SetBurger(BurgerBuilder burger)
        {
            _burger = burger;
        }
        public void GetCookedBurger()
        {
            _burger.WithMeat();
            _burger.WithTomato();
            _burger.WithCheese();
            _burger.WithSalad();
            _burger.WithSauce();
        }
    }
}
