using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CheeseBurgerDirector
    {
        private IBurgerBuilder _burger;
        public CheeseBurgerDirector(IBurgerBuilder burger)
        {
            _burger = burger;
        }
        public void Build() 
        {
            _burger.WithCheese();
            _burger.WithSauce();
            _burger.WithSalad();
            _burger.WithMeat();
            _burger.WithTomato();
        }
    }
}
