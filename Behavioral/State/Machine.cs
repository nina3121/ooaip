using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Machine
    {
        private IMachineState _state;

        public Machine()
        {
            _state = new TossACoinState();
        }

        public void SetState(IMachineState state)
        {
            _state = state;
        }

        public void TossACoin()
        {
            _state = _state.TossACoin();
        }

        public void DemandTheCoinBack()
        {
            _state = _state.DemandTheCoinBack();
        }

        public void SpinUp()
        {
            _state = _state.SpinUp();
        }

        public void GetTheBalloon()
        {
            _state = _state.GetTheBalloon();
        }
    }
}
