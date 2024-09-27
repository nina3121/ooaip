using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class HighTechWardrobe : IWardrobe
    {
        public string Print()
        {
            return "Шкаф в стиле хай-тек";
        }
    }
}
