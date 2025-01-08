using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class GetTheBalloonState : IMachineState
    {
        public IMachineState TossACoin()
        {
            Console.WriteLine("жвачка выдается. подождите, чтобы вставить монету");
            return this;
        }

        public IMachineState DemandTheCoinBack()
        {
            Console.WriteLine("жвачка выдается. дождитесь выдачи жвачки и вставьте монету, чтобы её забрать");
            return this;
        }

        public IMachineState SpinUp()
        {
            Console.WriteLine("ручка автомата прокручена, ожидайте выдачи жвачки");
            return this;
        }

        public IMachineState GetTheBalloon()
        {
            Console.WriteLine("жвачка получена, вы можете вставить еще одну монету");
            return new TossACoinState();
        }
    }
}
