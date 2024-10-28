using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Components
{
    public class PrimitiveComponent : IComponent
    {
        private double _value;

        public PrimitiveComponent(double value)
        {
            _value = value;
        }

        public IEnumerable<double> GetValue()
        {
            yield return _value;
        }
    }
}
