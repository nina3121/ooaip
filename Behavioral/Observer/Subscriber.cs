using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subscriber : IObserver
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }
        public void Update(string newspaper)
        {
            Console.WriteLine($"{_name} got the newspaper {newspaper}"); 
        }
    }
}
