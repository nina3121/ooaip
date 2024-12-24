using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Client
    {
        public void GetTheNewspaper()
        {
            TheNewYorkTimes theNewYorkTimes = new TheNewYorkTimes();
            TheWallStreetJournal theWallStreetJournal = new TheWallStreetJournal();

            Subscriber firstSubscriber = new Subscriber("Alice");
            Subscriber secondSubscriber = new Subscriber("Caitlyn");

            theWallStreetJournal.Attach(firstSubscriber);
            theWallStreetJournal.Attach(secondSubscriber);
            theNewYorkTimes.Attach(secondSubscriber);

            theWallStreetJournal.Notify();
        }
    }
}
