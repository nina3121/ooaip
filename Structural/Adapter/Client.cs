using Adapter.Ducks;
using Adapter.Frogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Client
    {
        public void SetDucks()
        {
            List<IDuck> ducks = new List<IDuck>();
            IDuck firstDomesticDuck = new DomesticDuck();
            IDuck firstWhistlingDuck = new WhistlingDuck();
            IDuck secondDomesticDuck = new DomesticDuck();
            IFrog hiddenFrog = new DesertRainFrog();

            ducks.Add(firstDomesticDuck);
            ducks.Add(secondDomesticDuck);
            ducks.Add(firstWhistlingDuck);

            IDuck adaptedDuck = new FrogToDuckAdapter(hiddenFrog);
            ducks.Add(adaptedDuck);

            foreach (var duck in ducks)
            {
                Console.WriteLine(duck.Crack());
            }
        }
    }
}
