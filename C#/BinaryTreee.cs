using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class BinaryTreee<T>
    {
        public T Value { get; set; }
        public BinaryTreee<T> LeftChild { get; set; }
        public BinaryTreee<T> RightChild { get; set; }

        public BinaryTreee(T value, BinaryTreee<T> leftChild = null, BinaryTreee<T> rightChild = null)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public void PrintVerticeWithLeaveSuccessors()
        {
            if (this.LeftChild != null || this.RightChild != null)
            {
                // Check if both children are leaves (or null)
                bool leftIsLeaf = this.LeftChild == null || (this.LeftChild.LeftChild == null && this.LeftChild.RightChild == null);
                bool rightIsLeaf = this.RightChild == null || (this.RightChild.LeftChild == null && this.RightChild.RightChild == null);

                // If both conditions are true, print the current node value
                if (leftIsLeaf && rightIsLeaf)
                {
                    Console.WriteLine(this.Value);
                }
            }

            // Recurse to the left and right children
            if (this.LeftChild != null)
            {
                this.LeftChild.PrintVerticeWithLeaveSuccessors();
            }

            if (this.RightChild != null)
            {
                this.RightChild.PrintVerticeWithLeaveSuccessors();
            }
        }
    }
}
