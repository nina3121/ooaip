using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Document
    {
        private string _value;
        private IMemento _memento;

        public Document(string value)
        {
            _value = value;
        }

        public void SetMemento(IMemento memento)
        {
            _memento = memento;
        }

        public IMemento CreateMemento()
        {
            return new DocumentMemento(_value);
        }
    }
}
