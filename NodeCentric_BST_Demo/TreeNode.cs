using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeCentric_BST_Demo
{
    /// <summary>
    /// TreeNode class is a node-centric container class for a binary search tree 
    /// with some behaviors:
    /// - Construction
    /// - Ability to traverse in in-order, pre-order, and post-order.
    /// 
    /// Trees built with this node-centric approach do NOT use a larger containing class,
    /// like a LinkedList class that has multiple LinkedListNode objects.   
    /// This approach requires manual creation of TreeNodes in an outside class,
    /// and manual reference setting to build a binary search tree.  
    /// </summary>
    internal class TreeNode
    {
        // ****************************************************************
        // Tree Data
        // ****************************************************************
        private int data;
        private TreeNode leftChild;
        private TreeNode rightChild;


        // Accessible from outside the class
        public int Data { get { return data; } set { data = value; } }
        public TreeNode Left { get { return leftChild; } set { leftChild = value; } }
        public TreeNode Right { get { return rightChild; } set { rightChild = value; } }
        

        // ****************************************************************
        // Tree Behaviors
        // ****************************************************************

        /// <summary>
        /// A TreeNode starts with the data it contains, but no references to either
        /// a left or a right child.
        /// </summary>
        /// <param name="data">Data the node contains</param>
        public TreeNode(int data)
        {
            this.data = data;
            leftChild = null!;
            rightChild = null!;
        }

        /// <summary>
        /// Recursively traverses through all nodes in the tree, starting with the root,
        /// to produce a printout of the node values in numerical order
        /// </summary>
        public void PrintInOrder()
        {
            // Is there a left node? Traverse to it.
            if (leftChild != null)
                leftChild.PrintInOrder();

            // Print this node's data
            Console.WriteLine(data);

            // Is there a right node? Traverse to it.
            if(rightChild != null)
                rightChild.PrintInOrder();
        }


        /// <summary>
        /// Recursively traverses through all nodes in a tree in the pre-order 
        /// traversal algorithm. This is helpful for getting back values in a
        /// binary search tree such that it can be replicated.
        /// </summary>
        public void PrintPreOrder()
        {
            // Print this node's data
            Console.WriteLine(data);

            // Is there a left node? Traverse to it.
            if (leftChild != null)
                leftChild.PrintPreOrder();

            // Is there a right node? Traverse to it.
            if (rightChild != null)
                rightChild.PrintPreOrder();
        }


        /// <summary>
        /// Recursively traverses through all nodes in a post-order algorithm.
        /// </summary>
        public void PrintPostOrder()
        {
            // Is there a left node? Traverse to it.
            if (leftChild != null)
                leftChild.PrintPostOrder();

            // Is there a right node? Traverse to it.
            if (rightChild != null)
                rightChild.PrintPostOrder();

            // Print this node's data
            Console.WriteLine(data);
        }
    }
}
