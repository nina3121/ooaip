using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.TVs
{
    public class TV2 : ITV
    {
        private int _currentChannel = 1;

        public void OnOff(bool f)
        {
            if (f)
            {
                Console.WriteLine("tv2 is on");
            }
            else
            {
                Console.WriteLine("tv2 is off");
            }
        }

        public void SetChannel(int channel)
        {
            _currentChannel = channel;
            Console.WriteLine($"channel {_currentChannel} is installed");
        }
    }
}
