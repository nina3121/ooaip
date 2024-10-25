using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FrogToDuckAdapter : IDuck
    {
        private readonly IFrog _frog;

        public FrogToDuckAdapter(IFrog frog)
        {
            _frog = frog == null ? throw new ArgumentNullException() : frog;
        }

        public string Crack()
        {
            return _frog.Croak(); 
        }
    }
}
