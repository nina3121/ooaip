using ChainOfResponsibility.Handlers;
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
            var buttonHandler = new ButtonHandler(new ViewFirstHandler(new WindowsHandler(null)));

            Console.WriteLine(buttonHandler.Handle("ViewFirst"));
            Console.WriteLine(buttonHandler.Handle("Output"));
        }
    }
}
