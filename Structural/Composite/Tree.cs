using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    public class Tree<T> : IEnumerable<T> where T : IComponent
    {
        public class Node 
        {
            public T Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(T value)
            {
                Value = value;
                Left = Right = null;
            }
        }

        Node root = null;
        public int count = 0;

        public void Add(T value)
        {
            Node node = new Node(value);
            if (root == null)
            {
                root = node;
                count++;
                return;
            }
            Node current = root;
            while (true)
            {
                double currentValue = current.Value.GetValue().First();
                double newValue = value.GetValue().First();
                if (newValue < currentValue)
                {
                    if (current.Left == null)
                    {
                        current.Left = node;
                        count++;
                        return;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }

                else
                {
                    if (current.Right == null)
                    {
                        current.Right = node;
                        count++;
                        return;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InOrderWalk(root).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<T> InOrderWalk(Node node)
        {
            if (node != null)
            {
                foreach (var left in InOrderWalk(node.Left))
                {
                    yield return left;
                }
                yield return node.Value;
                foreach (var right in InOrderWalk(node.Right))
                {
                    yield return right;
                }
            }
        }
    }
}
