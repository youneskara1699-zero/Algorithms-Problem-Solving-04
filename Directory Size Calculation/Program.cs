using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Size_Calculation
{
    internal class Program
    {
       class DirectoryNode
       {
           string Name { get; set; }
           int Size { get; set; }
           public List<DirectoryNode> Children { get; set; } = new List<DirectoryNode>();

           public DirectoryNode(string  name, int size)
           {
                Name = name;
                Size = size;
           }

            public int CalculateTotalSize()
            {
                int TotalSize = Size;

                foreach (var Child in Children)
                {
                    TotalSize += Child.CalculateTotalSize();
                }

                return TotalSize;
            }

            public void Print(string indent = " ")
            {
                Console.WriteLine($"{indent}{Name} (Size: {Size})");

                foreach (var Child in Children)
                {
                    Child.Print(indent + "  ");
                }
            }
       }
        static void Main(string[] args)
        {

            var root = new DirectoryNode("root", 0);
            var documents = new DirectoryNode("Documents", 0);
            var photos = new DirectoryNode("Photos", 0);


            documents.Children.Add(new DirectoryNode("Resume.docx", 50));
            documents.Children.Add(new DirectoryNode("Project.pdf", 100));


            photos.Children.Add(new DirectoryNode("Vacation.jpg", 200));


            root.Children.Add(documents);
            root.Children.Add(photos);


            // Print directory structure
            Console.WriteLine("Directory Structure:");
            root.Print();


            // Calculate and display total size
            Console.WriteLine($"\nTotal size of the directory: {root.CalculateTotalSize()} bytes");

        }
    }
}
