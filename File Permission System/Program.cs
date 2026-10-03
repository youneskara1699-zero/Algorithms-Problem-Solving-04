using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Permission_System
{
    internal class Program
    {
        class PermissionNode
        {
            string Name { get; set; }
            string Permissions { get; set; }

            public List <PermissionNode> Children { get; set; } = new List<PermissionNode>();

            public PermissionNode (string name, string permissions)
            {
                Name = name;
                Permissions = permissions;
            }

            public void PrintPermissions(string inheritedPermissions = "", string indent = "")
            {
               string effectivePermissions = Permissions == "" ? inheritedPermissions : Permissions;

                Console.WriteLine($"{indent}{Name}: {effectivePermissions}");

                foreach (var Child in Children)
                {
                    Child.PrintPermissions(effectivePermissions, indent);
                }
            }

        }
        static void Main(string[] args)
        {
            var root = new PermissionNode("Root", "rwx"); 
            var folder1 = new PermissionNode("Folder1", "rw-"); 
            var folder2 = new PermissionNode("Folder2", "");
            var file1 = new PermissionNode("File1", "");
            var file2 = new PermissionNode("File2", "r--"); 

            root.Children.Add(folder1);
            root.Children.Add(folder2);
            folder1.Children.Add(file1);
            folder2.Children.Add(file2);

            Console.WriteLine("File Permissions:");
            root.PrintPermissions();


        }
    }
}
