using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class DoublyLinkedList<T>
    {
        private class ListNode
        {
            public T Element { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PrevNode { get; set; }

            public ListNode(T element)
            {
                this.Element = element;
                this.NextNode = null;
                this.PrevNode = null;
            }

            public ListNode(T element, ListNode prevNode)
            {
                this.Element = element;
                this.PrevNode = prevNode;
                this.NextNode = null;
                prevNode.NextNode = this;
            }
        }

        private ListNode head;
        private ListNode tail;
        private int count;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public int Count => this.count;

        // Add an element at the end of the list
        public void Add(T item)
        {
            if (this.head == null)
            {
                this.head = new ListNode(item);
                this.tail = this.head;
            }
            else
            {
                ListNode newNode = new ListNode(item, this.tail);
                this.tail = newNode;
            }
            this.count++;
        }

        // Remove an element at a specific index
        public T RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            ListNode currentNode = this.head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.NextNode;
            }

            RemoveListNode(currentNode);
            return currentNode.Element;
        }

        // Remove a specific element
        public int Remove(T item)
        {
            ListNode currentNode = this.head;
            int currentIndex = 0;

            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, item))
                {
                    RemoveListNode(currentNode);
                    return currentIndex;
                }
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            return -1;
        }

        // Find the index of a specific element
        public int IndexOf(T item)
        {
            ListNode currentNode = this.head;
            int index = 0;

            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, item))
                {
                    return index;
                }
                currentNode = currentNode.NextNode;
                index++;
            }

            return -1;
        }

        // Check if the list contains a specific element
        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        // Insert an element at a specific index
        public void InsertAt(int index, T item)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            if (index == 0)
            {
                ListNode newNode = new ListNode(item)
                {
                    NextNode = this.head
                };

                if (this.head != null)
                {
                    this.head.PrevNode = newNode;
                }

                this.head = newNode;

                if (this.tail == null)
                {
                    this.tail = this.head;
                }
            }
            else if (index == count)
            {
                Add(item);
            }
            else
            {
                ListNode currentNode = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.NextNode;
                }

                ListNode newNode = new ListNode(item)
                {
                    NextNode = currentNode.NextNode,
                    PrevNode = currentNode
                };

                currentNode.NextNode.PrevNode = newNode;
                currentNode.NextNode = newNode;
            }

            count++;
        }

        // Retrieve an element at a specific index
        public T ElementAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            ListNode currentNode = this.head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.NextNode;
            }

            return currentNode.Element;
        }

        // Convert the list to an array
        public T[] ToArray()
        {
            T[] array = new T[this.count];
            ListNode currentNode = this.head;
            int index = 0;

            while (currentNode != null)
            {
                array[index] = currentNode.Element;
                currentNode = currentNode.NextNode;
                index++;
            }

            return array;
        }

        // Remove a node from the list
        private void RemoveListNode(ListNode node)
        {
            if (node.PrevNode != null)
            {
                node.PrevNode.NextNode = node.NextNode;
            }
            else
            {
                this.head = node.NextNode;
            }

            if (node.NextNode != null)
            {
                node.NextNode.PrevNode = node.PrevNode;
            }
            else
            {
                this.tail = node.PrevNode;
            }

            this.count--;
        }
    }
}
