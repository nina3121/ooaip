using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Ducks
{
    public class WhistlingDuck : IDuck
    {
        public string Crack()
        {
            return "whistling duck is cracking";
        }

        public string Eat()
        {
            return "whistling duck is eating";
        }
    }
}
