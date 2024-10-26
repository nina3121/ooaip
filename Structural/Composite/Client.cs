using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Client
    {
        public void BuildTree()
        {
            var tree = new Tree<IComponent>();
            tree.Add(new PrimitiveComponent(4));
            tree.Add(new PrimitiveComponent(5));
            tree.Add(new PrimitiveComponent(1));

            var composite = new CompositeComponent();
            composite.AddComponent(new PrimitiveComponent(2));
            composite.AddComponent(new PrimitiveComponent(9));

            tree.Add(composite);
            foreach (var value in tree)
            {
                Console.WriteLine(value.GetValue());
            }
        }
    }
}
