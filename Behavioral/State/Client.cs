using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Client
    {
        public void GetAGum()
        {
            Machine machine = new Machine();

            machine.TossACoin();
            machine.DemandTheCoinBack();

            machine.TossACoin();
            machine.SpinUp();
            machine.GetTheBalloon();
        }
    }
}
