using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mediator
{
    public class CoffeeMachine
    {
        public void MakeCoffee()
        {
            for (int i = 0; i < 24; i++)
            {
                if (i == 8)
                {
                    Console.WriteLine("making a coffee");
                }
            }
        }
    }
}
