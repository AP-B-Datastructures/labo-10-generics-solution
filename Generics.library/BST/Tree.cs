using System;

namespace Generics.library.BST
{
    public class Tree<T> where T : IComparable
    {
        public Node<T> Root { get; private set; }

        public int Count
        {
            get
            {
                return CountNodes(Root);
            }
        }

        public Node<T> Insert(T value)
        {
            if (Root is null)
            {
                Root = new(value);
                return Root;
            }
            else
            {
                var node = FindNode(Root, value);
                if (node.Value.CompareTo(value) == 0)
                {
                    return node;
                }

                if (node.Value.CompareTo(value) < 0)
                {
                    node.Left = new Node<T>(value);
                    return node.Left;
                }
                else
                {
                    node.Right = new Node<T>(value);
                    return node.Right;
                }
            }
        }

        public bool Contains(T value)
        {
            return FindNode(value) != null;
        }

        public Node<T> FindNode(T value)
        {
            var node = FindNode(Root, value);
            if (node != null && node.Value.CompareTo(value) == 0)
                return node;
            else
                return null;

        }

        public T Remove(T value)
        {
            Root = Remove(Root, value);
            return value;
        }

        public void Clear()
        {
            Root = null;
        }

        public T Lowest()
        {
            T min = default;
            var node = Root;
            if (node == null)
                throw new Exception("BST is empty");
            while (node != null)
            {
                min = node.Value;
                //we go down the tree on the left side all the way
                node = node.Left;
            }
            return min;
        }

        public T LowestRecursive()
        {
            return Lowest(Root);
        }

        public int Height()
        {
            return Height(Root);
        }

        private Node<T> Remove(Node<T> root, T value)
        {
            if (root == null)
                return null;

            //First descend the tree to find the node with the specified value
            if (root.Value.CompareTo(value) > 0)
            {
                root.Left = Remove(root.Left, value);
                return root;
            }
            else if (root.Value.CompareTo(value) < 0)
            {
                root.Right = Remove(root.Right, value);
                return root;
            }

            //found the node with the requested value, let"s remove it
            if (root.Left == null) // max. 1 child
                return root.Right;
            if (root.Right == null) // max. 1 child
                return root.Left;

            var min = FindMinValue(root.Right);
            var newn = Remove(root, min);                //remove the original node
            root.Value = min;                       //take over the value
            return newn;
        }

        private T FindMinValue(Node<T> root)
        {
            if (root == null)
                throw new KeyNotFoundException();
            if (root.Left != null)
                return FindMinValue(root.Left);
            return root.Value;
        }

        private Node<T> FindNode(Node<T> parent, T value)
        {
            Node<T> temp;

            if (parent == null)
                return parent;

            if (parent.Value.CompareTo(value) == 0)
                temp = parent;
            else if (parent.Value.CompareTo(value) > 0)
                temp = FindNode(parent.Left, value);
            else
                temp = FindNode(parent.Right, value);

            return (temp == null ? parent : temp);
        }

        private int Height(Node<T> node)
        {
            if (node == null)
                return 0;
            //The height is calculated by calculating the height of the left and right side
            //and take the largest of the 2
            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

        private int CountNodes(Node<T> node)
        {
            if (node == null)
                return 0;
            //The number of elements is calculated by summing the left side + the right side
            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }

        private T Lowest(Node<T> node)
        {
            if (node == null)
                throw new Exception("BST is empty");
            if (node.Left != null)
                return Lowest(node.Left);
            else
                return node.Value;
        }
    }
}