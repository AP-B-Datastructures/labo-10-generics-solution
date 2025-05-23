using System;

namespace Generics.library.BST
{
    public class Node<T> where T : IComparable
    {
        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
