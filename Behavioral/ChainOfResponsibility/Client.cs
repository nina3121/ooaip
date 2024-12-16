using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Client
    {
        public void DoSomething()
        {
            var buttonHandler = new ButtonHandler();
            var viewFirstHandler = new ViewFirstHandler();
            var windowsHandler = new WindowsHandler();

            buttonHandler.SetHandler(viewFirstHandler).SetHandler(windowsHandler);

            Console.WriteLine(buttonHandler.Handle("ViewFirst"));
            Console.WriteLine(buttonHandler.Handle("Output"));
        }
    }
}
