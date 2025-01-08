using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class TossACoinState : IMachineState
    {
        public IMachineState TossACoin()
        {
            Console.WriteLine("монета вставлена. вы можете прокрутить ручку, чтобы получить жвачку или вернуть монету назад");
            return new SpinUpState();
        }

        public IMachineState DemandTheCoinBack()
        {
            Console.WriteLine("чтобы вернуть монету, сначала вставьте её");
            return this;
        }

        public IMachineState SpinUp()
        {
            Console.WriteLine("чтобы прокрутить ручку, сначала надо вставить монету");
            return this;
        }

        public IMachineState GetTheBalloon()
        {
            Console.WriteLine("чтобы забрать жвачку, надо вставить монету");
            return this;
        }
    }
}
