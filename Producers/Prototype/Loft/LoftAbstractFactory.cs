using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class LoftAbstractFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new LoftChair();
        }
        public ISofa CreateSofa()
        {
            return new LoftSofa();
        }
        public IWardrobe CreateWardrobe()
        {
            return new LoftWardrobe();
        }
    }
}
