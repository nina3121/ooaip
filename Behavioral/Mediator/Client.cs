using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Client
    {
       public void DoСhores()
        {
            Mediator mediator = new Mediator();
            IrrigationSystemRequest irrigationSystemRequest = new IrrigationSystemRequest(new TimeOnly(12, 0, 0));
            mediator.Handle(irrigationSystemRequest);
        }
    }
}
