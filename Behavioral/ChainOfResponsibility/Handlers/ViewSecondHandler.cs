using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class ViewSecondHandler : WindowsHandler
    {
        public override object Handle(object handler)
        {
            if (handler?.ToString() == "ViewSecond")
            {
                return "ViewSecondHandler обрботал запрос";
            }
            return base.Handle(handler);
        }
    }
}
