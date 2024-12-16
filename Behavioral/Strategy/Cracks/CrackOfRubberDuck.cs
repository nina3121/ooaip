using Strategy.IStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cracks
{
    public class CrackOfRubberDuck : ICrack
    {
        public string Crack()
        {
            return "the rubber duck is ducking";
        }
    }
}
