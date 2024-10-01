using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Modern
{
    public class ModernSofa : ISofa
    {
        public void GetSofa() { }
        public ISofa Clone()
        {
            return new ModernSofa();
        }
    }
}
