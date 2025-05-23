using System;

namespace Generics.library.BST
{
    public class Tree
    {
        public Node Root { get; private set; }

        public int Count
        {
            get
            {
                return CountNodes(Root);
            }
        }

        public Node Insert(int value)
        {
            if (Root is null)
            {
                Root = new Node(value);
                return Root;
            }
            else
            {
                var node = FindNode(Root, value);
                if (node.Value == value)
                {
                    return node;
                }

                if (value < node.Value)
                {
                    node.Left = new Node(value);
                    return node.Left;
                }
                else
                {
                    node.Right = new Node(value);
                    return node.Right;
                }
            }
        }

        public bool Contains(int value)
        {
            return FindNode(value) != null;
        }

        public Node FindNode(int value)
        {
            var node = FindNode(Root, value);
            if (node != null && node.Value == value)
                return node;
            else
                return null;

        }

        public int Remove(int value)
        {
            Root = Remove(Root, value);
            return value;
        }

        public void Clear()
        {
            Root = null;
        }

        public int Lowest()
        {
            int min = int.MinValue;
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

        public int LowestRecursive()
        {
            return Lowest(Root);
        }

        public int Height()
        {
            return Height(Root);
        }

        private Node Remove(Node root, int value)
        {
            if (root == null)
                return null;

            //First descend the tree to find the node with the specified value
            if (root.Value > value)
            {
                root.Left = Remove(root.Left, value);
                return root;
            }
            else if (root.Value < value)
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

        private int FindMinValue(Node root)
        {
            if (root == null)
                return -1;
            if (root.Left != null)
                return FindMinValue(root.Left);
            return root.Value;
        }

        private Node FindNode(Node parent, int value)
        {
            Node temp;

            if (parent == null)
                return parent;

            if (parent.Value == value)
                temp = parent;
            else if (parent.Value > value)
                temp = FindNode(parent.Left, value);
            else
                temp = FindNode(parent.Right, value);

            return (temp == null ? parent : temp);
        }

        private int Height(Node node)
        {
            if (node == null)
                return 0;
            //The height is calculated by calculating the height of the left and right side
            //and take the largest of the 2
            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

        private int CountNodes(Node node)
        {
            if (node == null)
                return 0;
            //The number of elements is calculated by summing the left side + the right side
            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }

        private int Lowest(Node node)
        {
            if (node == null)
                return 0;
            if (node.Left != null)
                return Lowest(node.Left);
            else
                return node.Value;
        }
    }
}