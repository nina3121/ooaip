using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class VegetarianBurgerDirector
    {
        private IBurgerBuilder _burger;
        public VegetarianBurgerDirector(IBurgerBuilder burger)
        {
            _burger = burger;
        }
        public void Build()
        {
            _burger.WithSauce();
            _burger.WithSalad();
            _burger.WithCheese();
            _burger.WithTomato();
        }
    }
}
