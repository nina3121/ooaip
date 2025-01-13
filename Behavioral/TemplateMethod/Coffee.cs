using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Coffee : BuildDrink
    {
        protected override void Ingredient()
        {
            Console.WriteLine("завариваем кофе");
        }

        protected override void Adds()
        {
            Console.WriteLine("добавляем в кофе молоко");
        }
    }
}
