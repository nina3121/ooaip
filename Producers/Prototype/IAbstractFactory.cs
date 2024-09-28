using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        IWardrobe CreateWardrobe();
    }
}
