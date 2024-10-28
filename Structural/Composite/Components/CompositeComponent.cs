using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Components
{
    public class CompositeComponent : IComponent
    {
        private List<IComponent> _components = new List<IComponent>();

        public void AddComponent(IComponent component)
        {
            _components.Add(component);
        }

        public IEnumerable<double> GetValue()
        {
            foreach (var component in _components)
            {
                foreach (var value in component.GetValue())
                {
                    yield return value;
                }
            }
        }
    }
}
