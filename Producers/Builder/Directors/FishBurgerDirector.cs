using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FishBurgerDirector
    {
        private IBurgerBuilder _burger;
        public FishBurgerDirector(IBurgerBuilder burger)
        {
            _burger = burger;
        }
        public void Build()
        {
            _burger.WithFish();
            _burger.WithSauce();
            _burger.WithSalad();
            _burger.WithCheese();
            _burger.WithTomato();
        }
    }
}
