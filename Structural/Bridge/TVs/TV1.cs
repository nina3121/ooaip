using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.TVs
{
    public class TV1 : ITV
    {
        private int _currentChannel = 1;

        public void OnOff(bool f)
        {
            if (f)
            {
                Console.WriteLine("tv1 is on");
            }
            else
            {
                Console.WriteLine("tv1 is off");
            }    
        }

        public void SetChannel(int channel)
        {
            _currentChannel = channel;
            Console.WriteLine($"channel {_currentChannel} is installed");
        }
    }
}
