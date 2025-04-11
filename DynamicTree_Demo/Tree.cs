using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace DynamicTree_Demo
{
    internal class Tree
    {
        // ------------------------------------------------
        // Data
        // ------------------------------------------------
        private TreeNode root;

        //public TreeNode Root { get { return root; } }


        // ------------------------------------------------
        // Behaviors
        // ------------------------------------------------
        // Find the minimum
        // Add data to the tree
        // ... and whatever else you need!

        public Tree()
        {
            root = null;
        }

        /*
        public int FindMin()
        {
            // There is no root, so the tree is empty.
            if (root == null) 
            { 
                throw new Exception("Tree has no data."); 
            }

            // If we reach this point, there is a root.
            // Find the minimum value via iteration with a local 
            //   Node variable and return the data once we find 
            //   the left-most node.
            TreeNode current = root;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current.Data;
        }
        */


        
        public int FindMin()
        {
            // There is no root, so the tree is empty.
            if (root == null)
            {
                throw new Exception("Tree has no data.");
            }

            return FindMin(root);
        }       
        private int FindMin(TreeNode currentNode)
        {
            // Base case
            if (currentNode.Left == null)
                return currentNode.Data;

            // Can assume left child exists here
            return FindMin(currentNode.Left);
        }


    }
}
