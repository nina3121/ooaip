using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mediator
{
    public class CoffeeMachineHandler
    {
        public void Handler(AlarmRequest request)
        {
            if (request.Time.Hour == 8)
            {
                Console.WriteLine("making a coffee");
            }
        }
    }
}
