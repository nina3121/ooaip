using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class HighTechChair : IChair
    {
        public string Print()
        {
            return "Стул в стиле хай-тек";
        }
    }
}
