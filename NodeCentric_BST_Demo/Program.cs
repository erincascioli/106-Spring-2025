
// Erin Cascioli
// 4/7/25
// Demo: Binary Search Trees, in a node-centric approach


namespace NodeCentric_BST_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ****************************************************************
            // "Node-centric" tree 
            // Build a tree by creating many Nodes and linking them manually
            // (This works well when there isn't a defining "more" or "less"
            //   between tree nodes, like a talent tree!)
            // ****************************************************************

            // ----------------------------------------------------------------
            // Build the tree
            // ----------------------------------------------------------------

            // All trees start with a single root
            TreeNode root = new TreeNode(64);

            // Build the left subtree
            root.Left = new TreeNode(23);
            root.Left.Left = new TreeNode(15);
            root.Left.Left.Left = new TreeNode(4);
            root.Left.Right = new TreeNode(44);
            root.Left.Left.Right = new TreeNode(17);

            // Build the right subtree
            root.Right = new TreeNode(79);
            root.Right.Right = new TreeNode(99);
            root.Right.Right.Right = new TreeNode(100);
            root.Right.Left = new TreeNode(67);
            root.Right.Left.Right = new TreeNode(72);

            // ----------------------------------------------------------------
            // Iteration to largest & smallest values
            // ----------------------------------------------------------------

            // Iteration is similar to linked list iteration 
            TreeNode current = root;
            while(current.Right != null)
            {
                current = current.Right;
            }

            int largest = current.Data;
            Console.WriteLine("Largest value in tree: " + largest);

            // Iterate to the smallest value in the tree
            current = root;
            while (current.Left != null)
            {
                current = current.Left;
            }

            int smallest = current.Data;
            Console.WriteLine("Smallest value in tree: " + smallest);

            // ----------------------------------------------------------------
            // Traversal
            // ----------------------------------------------------------------

            // Call the in-order traversal recursive method, starting at the root.
            Console.WriteLine("\nIn-order traversal");
            root.PrintInOrder();

            // Call the pre-order traversal:
            Console.WriteLine("\nPre-order traversal");
            root.PrintPostOrder();
        }      
    }
}
