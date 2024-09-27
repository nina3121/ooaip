using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class LoftChair : IChair
    {
        public string Print()
        {
            return "Стул в стиле лофт";
        }
    }
}
