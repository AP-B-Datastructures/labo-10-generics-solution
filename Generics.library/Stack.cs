using System;

namespace Generics.library
{
    public class Stack<T>
    {
        private T[] _data = new T[10];
        private int _top = 0;

        public bool IsEmpty => this._top == 0;

        public bool IsFull => this._top == this._data.Length;

        public int Length => this._top;

        public Stack(int initialSize = 10)
        {
            this._data = new T[initialSize];
        }

        public void Push(T newValue)
        {
            if (this.IsFull)
            {
                this.ResizeArray();
            }

            this._data[this._top] = newValue;
            this._top++;
        }

        public T Pop()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("Pop failed because stack is empty");
            }
            this._top--;
            return this._data[this._top];
        }

        private void ResizeArray()
        {
            T[] newDataArray = new T[this._data.Length * 2];

            for (int i = 0; i < this._data.Length; ++i)
            {
                newDataArray[i] = this._data[i];
            }

            this._data = newDataArray;
        }
    }
}
