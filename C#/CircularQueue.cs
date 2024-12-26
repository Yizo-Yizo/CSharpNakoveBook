using System;

namespace C_
{
    public class CircularQueue<T>
    {
        private T[] arr;
        private int head;
        private int tail;
        private int count;
        private const int INITIAL_CAPACITY = 4;

        public CircularQueue(int capacity = INITIAL_CAPACITY)
        {
            this.arr = new T[capacity];
            this.head = 0;
            this.tail = 0;
            this.count = 0;
        }

        public int Count => this.count;

        public void Enqueue(T item)
        {
            GrowIfArrIsFull();
            this.arr[this.tail] = item;
            this.tail = (this.tail + 1) % this.arr.Length;
            this.count++;
        }

        public T Dequeue()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T result = this.arr[this.head];
            this.arr[this.head] = default(T); // Clear the slot for GC
            this.head = (this.head + 1) % this.arr.Length;
            this.count--;

            return result;
        }

        public T Peek()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return this.arr[this.head];
        }

        private void GrowIfArrIsFull()
        {
            if (this.count == this.arr.Length)
            {
                T[] extendedArr = new T[this.arr.Length * 2];
                CopyAllElements(extendedArr);
                this.arr = extendedArr;
                this.head = 0;
                this.tail = this.count;
            }
        }

        private void CopyAllElements(T[] extendedArr)
        {
            for (int i = 0; i < this.count; i++)
            {
                extendedArr[i] = this.arr[(this.head + i) % this.arr.Length];
            }
        }

        public void Clear()
        {
            this.arr = new T[INITIAL_CAPACITY];
            this.head = 0;
            this.tail = 0;
            this.count = 0;
        }
    }
}
