using System;
using Generics.library.SinglyLinkedList;

namespace Generics.library
{
    public class Hashtable<T> where T : IComparable
    {
        private SinglyLinkedList.List<T>[] array;
        public int Length {get; private set;}
        public Hashtable(int size)
        {
            array = new SinglyLinkedList.List<T>[size];
        }

        public void Add(T value)
        {
            var idx = CalculateHash(value);
            if (array[idx] == null)
                array[idx] = new SinglyLinkedList.List<T>();  //make sure that the LL is created

            array[idx].Add(value);
        }

        public void Remove(T value)
        {
            var idx = CalculateHash(value);
            if (array[idx] == null)
                array[idx] = new SinglyLinkedList.List<T>(); //make sure that the LL is created

            var index = array[idx].FindIndex(value);
            if (index > -1)
                array[idx].Remove(index);
        }

        public void Clear()
        {
            foreach (var item in array)
            {
                item.Clear();
            }
        }

        public bool Contains(T value)
        {
            var idx = CalculateHash(value);
            if (array[idx] == null)
                array[idx] = new SinglyLinkedList.List<T>(); //make sure that the LL is created

            if (array[idx].Find(value) != null)
                return true;

            return false;
        }

        private int CalculateHash(T value)
        {
            return Math.Abs(value.GetHashCode()) % array.Length;
        }
    }
}
