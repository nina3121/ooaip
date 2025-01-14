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
        public void CoffeeHandler(IRequest request)
        {
            if (((CoffeeRequest)request).GetTime().Hour == 8)
            {
                Console.WriteLine("making a coffee");
            }
        }
    }
}
