using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class DocumentMemento : IMemento 
    {
        private string _state;
        private DateTime _date;

        public DocumentMemento(string state)
        {
            _state = state;
            _date = DateTime.UtcNow;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public string GetState()
        {
            return _state;
        }
    }
}
