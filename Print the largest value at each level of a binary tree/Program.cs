using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_the_largest_value_at_each_level_of_a_binary_tree
{
    internal class Program
    {
        class TreeNode
        {
            public int Value { get; set; } 
            public TreeNode Left { get; set; } 
            public TreeNode Right { get; set; } 


            public TreeNode(int value)
            {
                Value = value; 
            }
        }


        class BinaryTree
        {
          
            public void PrintTree(TreeNode root, string indent = "")
            {
                if (root == null) return;


                PrintTree(root.Left, indent + "  "); 
                Console.WriteLine($"{indent}{root.Value}"); 
                PrintTree(root.Right, indent + "  "); 
            }


         
            public List<int> LargestValuesAtEachLevel(TreeNode root)
            {
                var result = new List<int>();
                if (root == null) return result;

                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);


               
                while (queue.Count > 0)
                {
                    int levelSize = queue.Count; 
                    int maxValue = int.MinValue;


                  
                    for (int i = 0; i < levelSize; i++)
                    {
                        var node = queue.Dequeue();
                        maxValue = Math.Max(maxValue, node.Value); 


                   
                        if (node.Left != null) queue.Enqueue(node.Left);
                        if (node.Right != null) queue.Enqueue(node.Right);
                    }

                    result.Add(maxValue); 
                }


                return result;
            }
        }
        static void Main(string[] args)
        {
            var tree = new BinaryTree();


            // Create a sample tree
            var root = new TreeNode(1);
            root.Left = new TreeNode(3);
            root.Right = new TreeNode(2);
            root.Left.Left = new TreeNode(5);
            root.Left.Right = new TreeNode(3);
            root.Right.Right = new TreeNode(9);


            // Print the tree
            Console.WriteLine("Binary Tree:");
            tree.PrintTree(root);


        
            Console.WriteLine("\nLargest Values at Each Level:");
            var largestValues = tree.LargestValuesAtEachLevel(root);
            for (int i = 0; i < largestValues.Count; i++)
            {
                Console.WriteLine($"Level {i + 1}: {largestValues[i]}");
            }



        }
    }
}
