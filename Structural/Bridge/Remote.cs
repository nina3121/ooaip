using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Remote
    {
        protected ITV _tv;

        public Remote(ITV tv)
        {
            _tv = tv;
        }

        public virtual void On()
        {
            _tv.OnOff(true);
        }

        public virtual void Off()
        {
            _tv.OnOff(false);
        }

        public virtual void SetChannel(int channel)
        {
            _tv.SetChannel(channel);
        }
    }
}
