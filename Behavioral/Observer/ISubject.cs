using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubject
    {
        void Attach(IObserver subscriber);

        void Detach(IObserver subscriber);

        void Notify();
    }
}
