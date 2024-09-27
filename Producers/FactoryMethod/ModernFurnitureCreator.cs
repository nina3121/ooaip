using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ModernFurnitureCreator : FurnitureCreator
    {
        protected override ISofa CreateSofa()
        {
            return new ModernSofa();
        }
        protected override IChair CreateChair()
        {
            return new ModernChair();
        }
        protected override IWardrobe CreateWardrobe()
        {
            return new ModernWardrobe();
        }
    }
}
