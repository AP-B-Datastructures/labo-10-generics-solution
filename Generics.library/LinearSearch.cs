using System;
using Generics.library.SinglyLinkedList;

namespace Generics.library
{
    public class LinearSearch
    {
        public static int Search(int[] Array, int value)
        {
            for (int i = 0; i < Array.Length; ++i)
            {
                var item = Array[i];
                if (item == value)
                    return i;
            }
            return -1;
        }

        public static int Search(SinglyLinkedList.List<int> list, int value)
        {
            return list.FindIndex(value);
        }
    }
}
