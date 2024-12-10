using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Projector
    {
        public string On()
        {
            return "projector is on";
        }

        public string Off()
        {
            return "projector is off";
        }
    }
}