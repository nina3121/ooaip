using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class HighTechFurniture : FurnitureCreator
    {
        protected override ISofa CreateSofa()
        {
            return new HighTechSofa();
        }
        protected override IChair CreateChair()
        {
            return new HighTechChair();
        }
        protected override IWardrobe CreateWardrobe()
        {
            return new HighTechWardrobe();
        }

    }
}
