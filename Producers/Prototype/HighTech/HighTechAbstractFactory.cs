using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class HighTechAbstractFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new HighTechChair();
        }
        public ISofa CreateSofa()
        {
            return new HighTechSofa();
        }
        public IWardrobe CreateWardrobe()
        {
            return new HighTechWardrobe();
        }
    }
}
