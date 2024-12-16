using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class ViewFirstHandler : WindowsHandler
    {
        public override object Handle(object handler)
        {
            if (handler?.ToString() == "ViewFisrt")
            {
                return "ViewFirstHandler обрботал запрос";
            }
            return base.Handle(handler);
        }
    }
}
