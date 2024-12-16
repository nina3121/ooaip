using Strategy.IStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ToSwim : ISwim
    {
        public string Swim()
        {
            return "evety duck can swim";
        }
    }
}
