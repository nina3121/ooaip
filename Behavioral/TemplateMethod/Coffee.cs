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

        protected override void IsSugar()
        {
            Console.WriteLine("хотите ли вы добавить сахар в кофе? (да - 0, нет - 1)");
            int isSugar = Convert.ToInt32(Console.ReadLine());
            if (isSugar == 0)
            {
                Console.WriteLine("сахар добавлен");
            }
            else
            {
                Console.WriteLine("кофе без сахара");
            }
        }

        protected override void Adds()
        {
            Console.WriteLine("добавляем в кофе молоко");
        }
    }
}
