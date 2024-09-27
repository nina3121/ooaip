using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class LoftWardrobe : IWardrobe
    {
        public string Print()
        {
            return "Шкаф в стиле лофт";
        }
    }
}
