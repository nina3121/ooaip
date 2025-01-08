using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Mediator
    {
        public void Notify(IRequest request)
        {
            request.Execute();
        }
    }
}
