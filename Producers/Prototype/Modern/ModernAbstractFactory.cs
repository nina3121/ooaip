using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Modern
{
    public class ModernAbstractFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }
        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
        public IWardrobe CreateWardrobe()
        {
            return new ModernWardrobe();
        } 
    }
}
