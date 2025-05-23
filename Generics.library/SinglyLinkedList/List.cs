using System;

namespace Generics.library.SinglyLinkedList
{
    public class List<T> where T : IComparable
    {
        public Node<T> First { get; private set; }
        public Node<T> Last  { get; private set; }
        public bool IsEmpty => this.First == null;
        public int Length { get; private set; }

        public void Add(T value)
        {
            Node<T> newValue = new Node<T>(value);

            if (this.IsEmpty)
                this.First = newValue;
            else
                this.Last.Next = newValue;

            this.Last = newValue;
            this.Length++;
        }

        public int FindIndex(T value)
        {
            Node<T> currentNode = this.First;
            int index = 0;

            while (currentNode != null && currentNode.Value.CompareTo(value) != 0)
            {
                currentNode = currentNode.Next;
                index++;
            }

            return currentNode == null ? -1 : index;
        }

        public Node<T> Find(T value)
        {
            Node<T> currentNode = this.First;

            while (currentNode != null && currentNode.Value.CompareTo(value) != 0)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public Node<T> Remove(int index)
        {
            if (index < 0 || index >= this.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index == 0)
            {
                return RemoveFirst();
            }

            Node<T> beforeIndex = this.First;

            for (int i = 1; i < index - 1; ++i)
            {
                beforeIndex = beforeIndex.Next;
            }

            Node<T> toRemove = beforeIndex.Next;

            beforeIndex.Next = beforeIndex.Next.Next;

            this.Length--;
            return toRemove;
        }

        public Node<T> RemoveFirst()
        {
            if (this.IsEmpty)
            {
                throw new IndexOutOfRangeException("LinkedList is Empty. Cannot remove first element.");
            }

            if (this.Length == 1)
            {
                this.Last = null;
            }

            Node<T> toRemove = this.First;

            this.First = this.First.Next;

            this.Length--;
            return toRemove;
        }

        public Node<T> RemoveLast()
        {
            return Remove(this.Length - 1);
        }

        public void Clear()
        {
            this.First = null;
            this.Last = null;
            this.Length = 0;
        }

        public override string ToString()
        {
            Node<T> node = this.First;

            var result = "";
            while (node != null)
            {
                result += node.ToString();
                node = node.Next;
                if (node != null)
                    result += " ";
            }

            return result;
        }
    }
}
