using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class LoftSofa : ISofa
    {
        public string Print()
        {
            return "Диван в стиле лофт";
        }
    }
}
