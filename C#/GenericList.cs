using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_
{
    public class GenericList<T>
    {
        
        private int count;

        private T[] values;
        
        public int Count { get { return count; } }

        public GenericList(int capacity)
        {
            values = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= values.Length)
            {
                ResizeArray();
            }
            values[count] = item;
            count++;
        }

        private void ResizeArray()
        {
            int newCapacity = values.Length * 2;
            T[] newValues = new T[newCapacity];

            for (int i = 0; i < values.Length; i++)
            {
                newValues[i] = values[i];
            }

            values = newValues;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }

            for (int i = index; i < count - 1; i++)
            {
                values[i] = values[i + 1];
            }

            values[count - 1] = default(T); // Clear the last element
            count--;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }

                return values[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }

                values[index] = value;
            }
        }

        public void InsertAt(int index, T item)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }

            if (count >= values.Length)
            {
                throw new InvalidOperationException("The list is full.");
            }

            for (int i = count; i > index; i--)
            {
                values[i] = values[i - 1];
            }

            values[index] = item;
            count++;
        }

        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                values[i] = default(T);
            }

            count = 0;
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (Equals(values[i], item))
                {
                    return i;
                }
            }

            return -1; // Item not found
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            for (int i = 0; i < count; i++)
            {
                sb.Append(values[i]);
                if (i < count - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append(" ]");

            return sb.ToString();
        }

    }
}
