using System;

namespace C_
{
    public class Deque<T>
    {
        private class ListNode
        {
            public T Element { get; set; }
            public ListNode PrevNode { get; set; }
            public ListNode NextNode { get; set; }

            public ListNode(T element)
            {
                this.Element = element;
                this.PrevNode = null;
                this.NextNode = null;
            }
        }

        private ListNode head;
        private ListNode tail;
        private int count;

        public Deque()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void PushStart(T item)
        {
            ListNode newNode = new ListNode(item);
            if (this.head == null)
            {
                // Deque is empty
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.NextNode = this.head;
                this.head.PrevNode = newNode;
                this.head = newNode;
            }
            this.count++;
        }

        public void PushEnd(T item)
        {
            ListNode newNode = new ListNode(item);
            if (this.tail == null)
            {
                // Deque is empty
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.PrevNode = this.tail;
                this.tail.NextNode = newNode;
                this.tail = newNode;
            }
            this.count++;
        }

        public T PopStart()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Deque is empty.");
            }

            T result = this.head.Element;
            this.head = this.head.NextNode;
            if (this.head != null)
            {
                this.head.PrevNode = null;
            }
            else
            {
                this.tail = null; // The deque is now empty
            }
            this.count--;
            return result;
        }

        public T PopEnd()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Deque is empty.");
            }

            T result = this.tail.Element;
            this.tail = this.tail.PrevNode;
            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null; // The deque is now empty
            }
            this.count--;
            return result;
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public int Count => this.count;
    }
}
