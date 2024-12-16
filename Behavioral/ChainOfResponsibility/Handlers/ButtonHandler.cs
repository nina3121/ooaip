using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class ButtonHandler : WindowsHandler
    {
        public override object Handle(object handler)
        {
            if (handler?.ToString() == "Button")
            {
                return "ButtonHandler обрботал запрос";
            }
            return base.Handle(handler);
        }
    }
}
