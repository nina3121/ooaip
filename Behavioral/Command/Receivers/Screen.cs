using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Screen
    {
        public string Up()
        {
            return "screen is on";
        }

        public string Down()
        {
            return "screen is off";
        }
    }
}
