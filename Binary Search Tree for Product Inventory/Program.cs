using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Binary_Search_Tree_for_Product_Inventory
{
    internal class Program
    {
        class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Product (int id, string name)
            {
                ID = id;
                Name = name;
            }

            public override string ToString()
            {
                return $"Product ID: {ID}, Name: {Name}";
            }
        }

        class BSTNode
        {
            public Product Product { get; set; }
            public BSTNode Left { get; set; }
            public BSTNode Right { get; set; }

            public BSTNode (Product product)
            {
                Product = product;
            }
        }

        class BST
        {
            private BSTNode root;

            public void Insert(Product product)
            {
                root = Insert(root, product);
            }

            private BSTNode Insert(BSTNode node, Product product)
            {
                if (node == null) return new BSTNode(product);

                if (product.ID < node.Product.ID)
                    node.Left = Insert(node.Left, product);

                else 
                    node.Right = Insert(node.Right, product);

               return node;
            }

            public Product Search (int id)
            {
                return Search(root, id)?.Product;
            }

            private BSTNode Search(BSTNode node, int id)
            {
                if (node == null || node.Product.ID == id) 
                return node;

                if (id < node.Product.ID)
                    return Search(node.Left, id);


                return Search(node.Right, id);
            }

            public void PrintInOrder()
            {
                PrintInOrder(root);
            }


            private void PrintInOrder(BSTNode node)
            {
                if (node == null) return;


                PrintInOrder(node.Left);
                Console.WriteLine(node.Product);
                PrintInOrder(node.Right);
            }
        }


        static void Main(string[] args)
        {
            var inventory = new BST();

            inventory.Insert(new Product(101, "Laptop"));
            inventory.Insert(new Product(102, "Smartphone"));
            inventory.Insert(new Product(100, "Tablet"));

            var product = inventory.Search(102);
            Console.WriteLine(product != null ? $"Found: {product}" : "Product not found");

            Console.WriteLine("\nProduct Inventory:");
            inventory.PrintInOrder();

        }
    }
}
