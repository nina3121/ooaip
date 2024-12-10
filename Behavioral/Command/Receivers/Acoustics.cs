using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Acoustics
    {
        public string On()
        {
            return "acoustics is on";
        }

        public string Off()
        {
            return "acoustics is off";
        }
    }
}
