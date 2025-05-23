using System;

namespace Generics.library.BST
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public int Value { get; set; }

        public Node Left { get; set; }
        public Node Right { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
