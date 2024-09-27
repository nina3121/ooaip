using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class VegetarianBurger : BurgerBuilder
    {
        private static VegetarianBurger _instance;
        private VegetarianBurger() { }
        private Burger _burger;
        private static readonly object _lock = new object();
        public static VegetarianBurger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new VegetarianBurger();
                        }
                    }
                }
                return _instance;
            }
        }
        public override void Reset()
        {
            _burger = new Burger();
        }
        public override void WithCheese()
        {
            _burger.AddIngredient("Cheese");
        }
        public override void WithSalad()
        {
            _burger.AddIngredient("Salad");
        }
        public override void WithSauce()
        {
            _burger.AddIngredient("Sauce");
        }
        public override void WithTomato()
        {
            _burger.AddIngredient("Tomato");
        }
        public override Burger GetBurger()
        {
            Burger burger = _burger;
            this.Reset();
            return burger;
        }
    }
}
