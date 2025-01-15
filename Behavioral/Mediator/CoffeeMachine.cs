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
        public void CoffeeHandler(AlarmRequest request)
        {
            if (request.GetTime().Hour == 8)
            {
                Console.WriteLine("making a coffee");
            }
        }
    }
}
