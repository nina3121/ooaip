using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Light
    {
        public string On()
        {
            return "light is on";
        }

        public string Off()
        {
            return "light is off";
        }
    }
}
