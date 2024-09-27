using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class LoftFurnitureCreator : FurnitureCreator
    {
        protected override ISofa CreateSofa()
        {
            return new LoftSofa();
        }
        protected override IChair CreateChair()
        {
            return new LoftChair();
        }
        protected override IWardrobe CreateWardrobe()
        {
            return new LoftWardrobe();
        }
    }
}
