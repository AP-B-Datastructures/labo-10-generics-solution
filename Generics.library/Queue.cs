using System;

namespace Generics.library
{
    public class Queue
    {

        private int[] _data = new int[10];
        private int front = -1;
        private int back = -1;

        public bool IsEmpty => throw new NotImplementedException();

        public bool IsFull => throw new NotImplementedException();
        public int Length => throw new NotImplementedException();

        public Queue(int initialSize = 10)
        {
            throw new NotImplementedException();
        }

        public void Enqueue(int newValue)
        {
            throw new NotImplementedException();
        }

        public int Dequeue()
        {
            throw new NotImplementedException();
        }


        private void ResizeArray()
        {
            throw new NotImplementedException();
        }

        private void ReorderArray()
        {
            throw new NotImplementedException();
        }
    }
}
