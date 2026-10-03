using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_System_Organization
{
    internal class Program
    {
       class FileNode
       {
           public  string Name { get; set; }
           public bool IsFile { get; set; }
           public  List<FileNode> Children { get; set; } = new List<FileNode>();

            public enum enType { Directory, File}
            public FileNode(string name, enType fType)
            {
                Name = name;
                IsFile = fType == enType.File? true : false;
            }

            public void Print (string indent = "")
            {
                Console.WriteLine(indent + (IsFile? "File: " : "Directory: ") + Name);

                foreach (var Child in Children)
                {
                    Child.Print(indent + " ");
                }
            }

        }
       static void Main(string[] args)
       {
            // Create the root directory
            var root = new FileNode("root", FileNode.enType.Directory);


            // Create subdirectories and files
            var documents = new FileNode("Documents", FileNode.enType.Directory);
            var photos = new FileNode("Photos", FileNode.enType.Directory);
            documents.Children.Add(new FileNode("Resume.docx", FileNode.enType.File));
            documents.Children.Add(new FileNode("Project.pdf", FileNode.enType.File));
            photos.Children.Add(new FileNode("Vacation.jpg", FileNode.enType.File));
            photos.Children.Add(new FileNode("Diving.jpg", FileNode.enType.File));
            photos.Children.Add(new FileNode("Family.jpg", FileNode.enType.File));


            // Add subdirectories to root
            root.Children.Add(documents);
            root.Children.Add(photos);


            // Display the file system structure
            Console.WriteLine("File System:\n");
            root.Print();

        }
    }
}
