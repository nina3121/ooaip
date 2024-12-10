using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Teapot
    {
        public string On()
        {
            return "teapot is on";
        }

        public string Off()
        {
            return "teapot is off";
        }
    }
}
