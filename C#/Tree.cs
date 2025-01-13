using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_
{
    public class Tree<T>
    {
        // The root of the tree 
        private TreeNode<T> root;

        /// <summary>Constructs the tree</summary> 
        /// <param name="value">the value of the node</param> 
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                 "Cannot insert null value!");
            }

            this.root = new TreeNode<T>(value);
        }

        /// <summary>Constructs the tree</summary> 
        /// <param name="value">the value of the root node</param> 
        /// <param name="children">the children of the root 
        /// node</param> 
        public Tree(T value, params Tree<T>[] children)
         : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary> 
        /// The root node or null if the tree is empty 
        /// </summary>
        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }

        /// <summary>Traverses and prints tree in 
        /// Depth-First Search (DFS) manner</summary> 
        /// <param name="root">the root of the tree to be 
        /// traversed</param> 
        /// <param name="spaces">the spaces used for 
        /// representation of the parent-child relation</param> 
        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if (this.root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }
        }

        /// <summary>Traverses and prints the tree in 
        /// Depth-First Search (DFS) manner</summary> 
        public void TraverseDFS()
        {
            this.PrintDFS(this.root, string.Empty);
        }

        public void RootsWithKSubTrees(int kNodes)
        {
            FindSubTrees(this.root, kNodes, string.Empty);
        }

        public int NumberOfLeaves()
        {
            int leaves = 0;

            CountLeaves(this.root, ref leaves, string.Empty);

            return leaves-1;
        }
      
        public void CountLeaves(TreeNode<T> node, ref int leaves, string spaces)
        {
            if (node == null)
            {
                return;
            }
            // Count total nodes in this subtree
            int count = 0;
            int totalNodes = CountNodes(node, ref count);

            if (totalNodes == 0)
            {
                leaves++;
            }

            for (int i = 0; i < node.ChildrenCount; i++)
            {
                CountLeaves(node.GetChild(i), ref leaves, spaces + " ");
            }
        }
        private void FindSubTrees(TreeNode<T> node, int kNodes, string spaces)
        {

            if (node == null)
            {
                return;
            }
            // Count total nodes in this subtree
            int count = 0;
            int totalNodes = CountNodes(node, ref count);

            if (totalNodes == kNodes)
            {
                Console.WriteLine(spaces + node.Value);
            }

            for (int i = 0; i < node.ChildrenCount; i++)
            {
                FindSubTrees(node.GetChild(i), kNodes, spaces + " ");
            }
        }

        private int CountNodes(TreeNode<T> node, ref int count)
        {
            if (node == null)
            {
                return 0;
            }

            for (int i = 0; i < node.ChildrenCount; i++)
            {
                count++;
                CountNodes(node.GetChild(i), ref count);
            }

            return count;
        }
    }
}

