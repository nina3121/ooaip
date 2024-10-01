using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Client
    {
        public void UsePrototype()
        {
            var sofa = new HighTechSofa();
            var highTechSofa = new HighTechAbstractFactory();
            highTechSofa.SetSofa(sofa);
            var clonedSofa = highTechSofa.CreateSofa();
            clonedSofa.GetSofa();
        }
    }
}
