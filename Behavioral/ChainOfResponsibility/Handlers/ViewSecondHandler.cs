using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class ViewSecondHandler : WindowsHandler
    {
        private IHandler _handler;

        public ViewSecondHandler(IHandler handler) : base(handler)
        {
            _handler = handler == null ? throw new ArgumentNullException(nameof(handler)) : handler;
        }
        public override object Handle(object handler)
        {
            if (handler?.ToString() == "ViewSecond")
            {
                return "ViewSecondHandler обработал запрос";
            }
            return base.Handle(handler);
        }
    }
}
