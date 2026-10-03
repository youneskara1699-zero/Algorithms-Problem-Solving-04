using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determine_if_given_Two_Trees_are_Identical_or_not
{
    internal class Program
    {
        class TreeNode
        {
            public int Value { get; set; }
            public TreeNode Left { get; set; }
            public  TreeNode Right { get; set; }

            public TreeNode (int value)
            {
                Value = value;
            }
        }

        class BinaryTree
        {
            public bool AreIdentical(TreeNode root1, TreeNode root2)
            {
                if (root1 == null && root2 == null ) return true;

                if (root1 == null || root2 == null ) return false;

                return root1.Value == root2.Value && AreIdentical(root1.Left, root2.Left) && AreIdentical(root1.Right, root2.Right);
            }

            public void PrintTree(TreeNode root, string indent = "")
            {
                if (root == null) return;


                PrintTree(root.Left, indent + "  "); 
                Console.WriteLine($"{indent}{root.Value}"); 
                PrintTree(root.Right, indent + "  ");

            }

        static void Main(string[] args)
        {

                var tree = new BinaryTree();


                var root1 = new TreeNode(1);
                root1.Left = new TreeNode(2);
                root1.Right = new TreeNode(3);
                root1.Left.Left = new TreeNode(4);
                root1.Left.Right = new TreeNode(5);

                var root2 = new TreeNode(1);
                root2.Left = new TreeNode(2);
                root2.Right = new TreeNode(3);
                root2.Left.Left = new TreeNode(4);
                root2.Left.Right = new TreeNode(5);


            
                Console.WriteLine("Tree 1:");
                tree.PrintTree(root1);


                Console.WriteLine("\nTree 2:");
                tree.PrintTree(root2);

                Console.WriteLine("\nAre the two trees identical?");
                Console.WriteLine(tree.AreIdentical(root1, root2)
                    ? "Yes, the trees are identical."
                    : "No, the trees are not identical.");

                var root3 = new TreeNode(1);
                root3.Left = new TreeNode(2);
                root3.Right = new TreeNode(4);


                Console.WriteLine("\nTree 3:");
                tree.PrintTree(root3);

                Console.WriteLine("\nAre Tree 1 and Tree 3 identical?");
                Console.WriteLine(tree.AreIdentical(root1, root3)
                    ? "Yes, the trees are identical."
                    : "No, the trees are not identical.");

            }
        }
    }
}
