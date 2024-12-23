using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class WindowsHandler : IHandler
    {
        private IHandler _handler;

        public WindowsHandler(IHandler handler)
        {
            _handler = handler == null ? throw new ArgumentNullException(nameof(handler)) : handler;
        }

        public virtual object Handle(object handler)
        {
            if (_handler != null)
            {
                return _handler.Handle(handler);
            }
            return "не могу обработать этот запрос";
        }
    }
}
