using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Depth_of_a_Binary_Tree
{
    internal class Program
    {
        class TreeNode
        {
            int Value { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(int value) 
            { 
                Value = value;
            }

        }

        class BinaryTree
        {
            public int MaxDepth(TreeNode root)
            {
                if (root == null) return 0;

                int LeftDepth = MaxDepth(root.Left);
                int RightDepth = MaxDepth(root.Right);

                return Math.Max(LeftDepth, RightDepth) + 1;
            }


        }
        static void Main(string[] args)
        {
            var tree = new BinaryTree();

            var root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.Left.Right = new TreeNode(5);

            Console.WriteLine($"Maximum Depth: {tree.MaxDepth(root)}");


        }
    }
}
