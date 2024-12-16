using Strategy.IStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cracks
{
    public class StandardCrack : ICrack
    {
        public string Crack()
        {
            return "crack for normal duck (and for mechanical one)";
        }
    }
}
