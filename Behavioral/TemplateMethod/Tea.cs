using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Tea : BuildDrink
    {
        protected override void Ingredient()
        {
            Console.WriteLine("завариваем чай");
        }

        protected override void Adds()
        {
            Console.WriteLine("добавляем в чай лимон");
        }
    }
}
