using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class LoftSofa : ISofa
    {
        public void GetSofa() { }
        public ISofa Clone()
        {
            return new LoftSofa();
        }
    }
}
