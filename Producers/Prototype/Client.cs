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
            var chair = new HighTechChair();
            var sofa = new HighTechSofa();
            var wardrobe = new HighTechWardrobe();
            var highTech = new HighTechAbstractFactory(chair, sofa, wardrobe);
            var clonedSofa = highTech.CreateSofa();
            clonedSofa.GetSofa();
        }
    }
}
