using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Frogs
{
    public class DesertRainFrog : IFrog
    {
        public string Croak()
        {
            return "desert frog is croacking";
        }

        public string Jump()
        {
            return "desert frog is jumping";
        }
    }
}
