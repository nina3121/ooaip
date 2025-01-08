using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Client
    {
        public void GetTheDrink()
        {
            Coffee coffee = new Coffee();
            coffee.Cook();

            Tea tea = new Tea();
            tea.Cook();
        }
    }
}
