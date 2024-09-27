using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public abstract class BurgerBuilder
    {
        protected Burger burger;
        public virtual void Reset()
        {
            burger = new Burger();
        }
        public virtual void WithCheese() { }
        public virtual void WithMeat() { }
        public virtual void WithTomato() { }
        public virtual void WithSauce() { }
        public virtual void WithSalad() { }
        public virtual Burger GetBurger()
        {
            return burger;
        }
    }
}
