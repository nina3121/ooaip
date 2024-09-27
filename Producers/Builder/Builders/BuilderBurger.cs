using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BuilderBurger : IBurgerBuilder 
    {
        private Burger _burger;
        public BuilderBurger()
        {
            _burger = new Burger();
        }
        public void WithCheese()
        {
            _burger.AddIngredient("Cheese");
        }
        public void WithMeat()
        {
            _burger.AddIngredient("Meat");
        }
        public void WithTomato()
        {
            _burger.AddIngredient("Tomato");
        }
        public void WithSauce()
        {
            _burger.AddIngredient("Sauce");
        }
        public void WithSalad()
        {
            _burger.AddIngredient("Salad");
        }
        public void WithFish()
        {
            _burger.AddIngredient("Fish");
        }
        public Burger Build() 
        {
            return _burger;
        }
    }
}
