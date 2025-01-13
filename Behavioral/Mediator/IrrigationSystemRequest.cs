using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class IrrigationSystemRequest : IRequest
    {
        private Alarm _alarm;
        private IrrigationSystem _irrigationSystem;
    
        public IrrigationSystemRequest(Alarm alarm, IrrigationSystem irrigationSystem)
        {
            _alarm = alarm == null ? throw new ArgumentNullException(nameof(alarm)) : alarm;
            _irrigationSystem = irrigationSystem == null ? throw new ArgumentNullException(nameof(irrigationSystem)) : irrigationSystem;
        }

        public Alarm Alarm => _alarm;
        public IrrigationSystem IrrigationSystem => _irrigationSystem;
    }
}
