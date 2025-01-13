using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class BinaryTree
    {
        /// <summary>The value stored in the current node</summary>
        public int Value { get; set; }

        /// <summary>The left child of the current node</summary>
        public BinaryTree LeftChild { get; private set; }

        /// <summary>The right child of the current node</summary>
        public BinaryTree RightChild { get; private set; }

        /// <summary>Constructs a binary tree</summary>
        /// <param name="value">The value of the tree node</param>
        /// <param name="leftChild">The left child of the tree</param>
        /// <param name="rightChild">The right child of the tree</param>
        public BinaryTree(int value, BinaryTree leftChild, BinaryTree rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        /// <summary>Constructs a binary tree with no children</summary>
        /// <param name="value">The value of the tree node</param>
        public BinaryTree(int value) : this(value, null, null)
        {
        }

        /// <summary>
        /// Counts the occurrences of a given number in the tree
        /// </summary>
        /// <param name="target">The number to count</param>
        /// <returns>The count of occurrences</returns>
        public int CountOccurrences(int target)
        {
            int count = 0;
            CountOccurrencesRecursive(this, target, ref count);
            return count;
        }

        /// <summary>
        /// Recursively counts the occurrences of the target number
        /// </summary>
        /// <param name="node">The current node</param>
        /// <param name="target">The number to count</param>
        /// <param name="count">Reference to the count variable</param>
        private void CountOccurrencesRecursive(BinaryTree node, int target, ref int count)
        {
            if (node == null)
                return;

            if (node.Value == target)
                count++;

            CountOccurrencesRecursive(node.LeftChild, target, ref count);
            CountOccurrencesRecursive(node.RightChild, target, ref count);
        }
    }
}
