using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class ViewFirstHandler : WindowsHandler
    {
        private IHandler _handler;

        public ViewFirstHandler(IHandler handler) : base(handler)
        {
            _handler = handler == null ? throw new ArgumentNullException(nameof(handler)) : handler;
        }

        public override object Handle(object handler)
        {
            if (handler?.ToString() == "ViewFisrt")
            {
                return "ViewFirstHandler обработал запрос";
            }
            return base.Handle(handler);
        }
    }
}
