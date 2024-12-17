using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Caretaker
    {
        private readonly List<IMemento> _memento = new List<IMemento>();
        
        public void SaveState(IMemento memento)
        {
            _memento.Add(memento);
        }

        public IMemento GetLastState()
        {
            if (_memento.Count != 0)
            {
                return _memento[_memento.Count - 1];
            }
            else
            {
                throw new Exception("the list of mementos is empty");
            }
        }
    }
}
