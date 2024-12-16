using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class InputHandler : WindowsHandler
    {
        public override object Handle(object handler)
        {
            if (handler?.ToString() == "Input")
            {
                return "InputHandler обрботал запрос";
            }
            return base.Handle(handler);
        }
    }
}
