using System;

namespace Generics.library
{
    public class Stack
    {

        private int[] data = new int[10];
        private int top = -1;

        public bool IsEmpty => throw new NotImplementedException();

        public bool IsFull => throw new NotImplementedException();
        public int Length => throw new NotImplementedException();

        public Stack(int initialSize = 10)
        {
            throw new NotImplementedException();
        }

        public void Push(int newValue)
        {
            throw new NotImplementedException();
        }

        public int Pop()
        {
            throw new NotImplementedException();
        }

        private void ResizeArray()
        {
            throw new NotImplementedException();
        }
    }
}
