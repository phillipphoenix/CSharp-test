using System.Collections.Generic;

namespace Opg1
{
    public class Node<T>
    {
        public Node()
        {
            Children = new HashSet<Node<T>>();
        }

        public T Value { get; set; }
        public Node<T> Parent { get; set; }
        public ICollection<Node<T>> Children { get; set; }
    }
}
