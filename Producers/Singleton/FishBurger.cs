using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class FishBurger : BurgerBuilder
    {
        private static FishBurger _instance;
        private static readonly object _lock = new object();
        private Burger _burger;
        private FishBurger() { }
        public static FishBurger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new FishBurger();
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
        public override void WithMeat()
        {
            _burger.AddIngredient("Fish");
        }
        public override Burger GetBurger()
        {
            Burger burger = _burger;
            this.Reset();
            return burger;
        }
    }
}
