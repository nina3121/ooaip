using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SpinUpState : IMachineState
    {
        public IMachineState TossACoin()
        {
            Console.WriteLine("монета уже вставлена, ручка автомата уже прокручена");
            return this;
        }

        public IMachineState DemandTheCoinBack()
        {
            Console.WriteLine("уже прокручена ручка автомата. дождитесь выдачи жвачки и вставьте монету, чтобы её забрать");
            return this;
        }

        public IMachineState SpinUp()
        {
            Console.WriteLine("ручка автомата прокручена, ожидайте выдачи жвачки");
            return new GetTheBalloonState();
        }

        public IMachineState GetTheBalloon()
        {
            Console.WriteLine("чтобы получить жвачку, прокрутите ручку");
            return this;
        }
    }
}
