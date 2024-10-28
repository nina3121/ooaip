using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface ITV 
    {
        public void OnOff(bool f);

        public void SetChannel (int channel);
    }
}
