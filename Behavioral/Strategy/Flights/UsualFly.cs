using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.IStrategy;

namespace Strategy
{
    public class UsualFly : IFly
    {
        public string Fly()
        {
            return "the normal duck can fly";
        }
    }
}
