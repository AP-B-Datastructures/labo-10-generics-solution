using System;

namespace Generics.library
{
    public class Queue<T>
    {
        private T[] _data = new T[10];
        int _back = 0;
        int _front = 0;

        public bool IsEmpty => this._front == this._back;

        public bool IsFull => this._back >= this._data.Length;
        public int Length => this._back - this._front;

        public Queue(int initialSize = 10)
        {
            this._data = new T[initialSize];
        }

        public void Enqueue(T newValue)
        {
            if (IsFull)
            {
                if (this.Length < this._data.Length / 2)
                {
                    ReorderArray();
                }
                else
                {
                    ResizeArray();
                }
            }

            this._data[this._back] = newValue;
            this._back++;
        }

        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("ERROR: Can't dequeue an empty queue");
            }
            T result = this._data[this._front];
            this._front++;
            return result;
        }


        private void ResizeArray()
        {
            T[] newDataArray = new T[this._data.Length * 2];

            for (var i = this._front; i < this._back; ++i)
            {
                newDataArray[i] = this._data[i];
            }

            this._data = newDataArray;
        }

        private void ReorderArray()
        {
            for (var i = this._front; i < this._back; ++i)
            {
                this._data[i - this._front] = this._data[i];
            }

            this._back = this._back - this._front;
            this._front = 0;
        }
    }
}
