using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IMachineState
    {
        IMachineState TossACoin();
        IMachineState DemandTheCoinBack();
        IMachineState SpinUp();
        IMachineState GetTheBalloon(); 
    }
}
