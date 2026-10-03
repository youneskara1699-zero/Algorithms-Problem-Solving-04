using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category_Hierarchy
{
    internal class Program
    {

        class CategoryNode
        {
            public string Name { get; set; } 
            public List<CategoryNode> SubCategories { get; set; } = new List<CategoryNode>(); 

            public CategoryNode(string name)
            {
                Name = name; 
            }

          
            public void Print(string indent = "")
            {
                Console.WriteLine(indent + Name); 
                foreach (var subCategory in SubCategories) 
                {
                    subCategory.Print(indent + "  "); 
                }
            }
        }
        static void Main(string[] args)
        {

            var root = new CategoryNode("Electronics"); 
            var mobiles = new CategoryNode("Mobiles"); 
            var laptops = new CategoryNode("Laptops");
            var samsung = new CategoryNode("Samsung");
            var apple = new CategoryNode("Apple"); 
            var HP = new CategoryNode("HP");
            var Lenovo = new CategoryNode("Lenovo");

            mobiles.SubCategories.Add(samsung);
            mobiles.SubCategories.Add(apple);
            root.SubCategories.Add(mobiles);
            root.SubCategories.Add(laptops);
            laptops.SubCategories.Add(HP);
            laptops.SubCategories.Add(Lenovo);
         
            Console.WriteLine("Category Hierarchy:");
            root.Print();

        }
    }
}
