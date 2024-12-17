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
            _date = DateTime.Now;
        }

        public string GetDate()
        {
            return _date.ToShortDateString();
        }

        public string GetState()
        {
            return _state;
        }

        public void SetState(string state)
        {
            _state = state;
        }
    }
}
