using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBurgerBuilder
    {
        void WithCheese() { }
        void WithMeat() { }
        void WithTomato() { }
        void WithSauce() { }
        void WithSalad() { }
        void WithFish() { }
    }
}
