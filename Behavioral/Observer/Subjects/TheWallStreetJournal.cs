using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Sublects
{
    public class TheWallStreetJournal : ISubject
    {
        public event Action<string> NewsPublished;

        public void Attach(IObserver observer)
        {
            NewsPublished += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            NewsPublished -= observer.Update;
        }

        public void Notify()
        {
            NewsPublished?.Invoke("TheWallStreetJournal");
        }
    }
}
