using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class LoftChair : IChair
    { 
        public void GetChair() { }
        public IChair Clone()
        {
            return new LoftChair();
        }
    }
}
