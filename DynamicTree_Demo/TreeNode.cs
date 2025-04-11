using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTree_Demo
{
    internal class TreeNode
    {
        // ------------------------------------------------
        // Data
        // ------------------------------------------------
        private int data;
        private TreeNode leftChild;
        private TreeNode rightChild;

        // ------------------------------------------------
        // Properties
        // ------------------------------------------------
        public int Data { get { return data; } set { data = value; } }
        public TreeNode Left { get { return leftChild; } set { leftChild = value; } }
        public TreeNode Right { get { return rightChild; } set { rightChild = value; } }

        // ------------------------------------------------
        // Constructor
        // ------------------------------------------------
        public TreeNode(int data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
        }

        // ------------------------------------------------
        // No behaviors!
        // ------------------------------------------------
    }
}
