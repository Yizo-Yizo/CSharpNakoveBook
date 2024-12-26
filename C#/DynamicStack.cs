using System;

public class DynamicStack<T>
{
    private class ListNode
    {
        public T Element { get; set; }
        public ListNode PreviousNode { get; set; }

        public ListNode(T element)
        {
            this.Element = element;
            this.PreviousNode = null;
        }

        public ListNode(T element, ListNode previousNode)
        {
            this.Element = element;
            this.PreviousNode = previousNode;
        }
    }

    private ListNode top;
    private int count;

    public DynamicStack()
    {
        this.top = null;
        this.count = 0;
    }

    // Adds an item to the stack
    public void Push(T item)
    {
        if (this.top == null)
        {
            this.top = new ListNode(item);
        }
        else
        {
            ListNode newNode = new ListNode(item, this.top);
            this.top = newNode;
        }
        this.count++;
    }

    // Removes and returns the top item from the stack
    public T Pop()
    {
        if (this.count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = this.top.Element;
        this.top = this.top.PreviousNode;
        this.count--;

        return item;
    }

    // Returns the top item without removing it
    public T Peek()
    {
        if (this.count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return this.top.Element;
    }

    // Returns the number of items in the stack
    public int Count()
    {
        return this.count;
    }

    // Removes all items from the stack
    public void Clear()
    {
        this.top = null;
        this.count = 0;
    }
}
