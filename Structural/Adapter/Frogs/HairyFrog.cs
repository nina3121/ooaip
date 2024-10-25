using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Frogs
{
    public class HairyFrog : IFrog
    {
        public string Croak()
        {
            return "hairy frog is croacking";
        }

        public string Swim()
        {
            return "hairy frog is swimming";
        }
    }
}
