using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class ButtonHandler : WindowsHandler
    {
        private IHandler _handler;

        public ButtonHandler(IHandler handler) : base (handler)
        {
            _handler = handler == null ? throw new ArgumentNullException(nameof(handler)) : handler;
        }

        public override object Handle(object handler)
        {
            if (handler?.ToString() == "Button")
            {
                return "ButtonHandler обработал запрос";
            }
            return base.Handle(handler);
        }
    }
}
