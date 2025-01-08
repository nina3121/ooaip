using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class RequestIrrigationSystem : IRequest
    {
        private Alarm _alarm;
        private IrrigationSystem _irrigationSystem;
    
        public RequestIrrigationSystem(Alarm alarm, IrrigationSystem irrigationSystem)
        {
            _alarm = alarm == null ? throw new ArgumentNullException(nameof(alarm)) : alarm;
            _irrigationSystem = irrigationSystem == null ? throw new ArgumentNullException(nameof(irrigationSystem)) : irrigationSystem;
        }

        public void Execute()
        {
            _alarm.AlarmHandler();
            _irrigationSystem.WaterPlants();
        }
    }
}
