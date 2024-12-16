using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class WindowsHandler : IHandler
    {
        private IHandler _handler;

        public IHandler SetHandler(IHandler handler)
        {
            _handler = handler;
            return handler;
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
