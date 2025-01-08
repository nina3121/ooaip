using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class DemandTheCoinBackState : IMachineState
    {
        public IMachineState TossACoin()
        {
            Console.WriteLine("монета уже вставлена, вы можете её забрать");
            return this;
        }

        public IMachineState DemandTheCoinBack()
        {
            Console.WriteLine("монета получена назад");
            return new TossACoinState();
        }

        public IMachineState SpinUp()
        {
            Console.WriteLine("монета возвращена. чтобы прокрутить ручку, вставьте монету");
            return new TossACoinState();
        }

        public IMachineState GetTheBalloon()
        {
            Console.WriteLine("монета возвращена. чтобы получить жвачку, вставьте монету");
            return new TossACoinState();
        }
    }
}
