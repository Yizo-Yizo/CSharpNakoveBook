using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class LinkedListSorting
    {
        private class ListNode
        {
            public int Element { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode(int element)
            {
                this.Element = element;
                NextNode = null;
            }

            public ListNode(int element, ListNode prevNode)
            {
                this.Element = element;
                prevNode.NextNode = this;
            }
        }

        private ListNode head;
        private ListNode tail;
        private int count;

        public LinkedListSorting()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void SortNumbers()
        {
            if (head == null || head.NextNode == null)
            {
                // The list is empty or contains only one element, no sorting needed
                return;
            }

            bool swapped;
            do
            {
                swapped = false;
                ListNode currentNode = head;
                ListNode prevNode = null;

                while (currentNode != null && currentNode.NextNode != null)
                {
                    if (currentNode.Element > currentNode.NextNode.Element)
                    {
                        // Swap the current node with the next node
                        SwapNodes(prevNode, currentNode, currentNode.NextNode);
                        swapped = true;

                        // After swapping, prevNode should point to the secondNode (new currentNode)
                        if (prevNode == null)
                        {
                            prevNode = head; // If head was swapped, update prevNode to new head
                        }
                        else
                        {
                            prevNode = prevNode.NextNode;
                        }
                    }
                    else
                    {
                        // Move to the next node
                        prevNode = currentNode;
                        currentNode = currentNode.NextNode;
                    }
                }
            }
            while (swapped);
        }


        private void SwapNodes(ListNode prevNode, ListNode firstNode, ListNode secondNode)
        {
            if (prevNode == null)
            {
                // Swapping involves the head of the list
                head = secondNode;
            }
            else
            {
                prevNode.NextNode = secondNode;
            }

            firstNode.NextNode = secondNode.NextNode;
            secondNode.NextNode = firstNode;

            // Update the tail if necessary
            if (firstNode.NextNode == null)
            {
                tail = firstNode;
            }
        }


        public void Add(int item)
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

        public int RemovedAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            int currentIndex = 0;
            ListNode currentNode = this.head;
            ListNode prevNode = null;
            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            RemoveListNode(currentNode, prevNode);

            return currentNode.Element;
        }

        private void RemoveListNode(ListNode node, ListNode prevNode)
        {
            count--;
            if (count == 0)
            {
                this.head = null;
                this.tail = null;
            }
            else if (prevNode == null)
            {
                this.head = node.NextNode;
            }
            else
            {
                prevNode.NextNode = node.NextNode;
            }

            if (object.ReferenceEquals(this.tail, node))
            {
                this.tail = prevNode;
            }
        }

        public int Remove(int item)
        {
            int currentIndex = 0;
            ListNode currentNode = this.head;
            ListNode prevNode = null;

            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, item))
                {
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            if (currentNode != null)
            {
                RemoveListNode(currentNode, prevNode);
                return currentIndex;
            }
            else
            {
                return -1;
            }
        }

        public int IndexOf(int item)
        {
            int index = 0;
            ListNode currentNode = this.head;
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

        public bool Contains(int item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;
        }

        public int this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index " + index);
                }
                ListNode currentNode = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }

                return currentNode.Element;
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index " + index);
                }
                ListNode currentNode = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }

                currentNode.Element = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

    }
}
