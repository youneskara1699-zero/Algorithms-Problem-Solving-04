using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making_Process
{
    internal class Program
    {
        class DecisionNode
        {
            public string Question {get;set;}
            public DecisionNode Yes {get;set;}
            public DecisionNode No {get;set;}

            public DecisionNode(string question)
            {
                Question = question;
            }
        }
        static void Main(string[] args)
        {
            var root = new DecisionNode("Do you like active pets?");
            root.Yes = new DecisionNode("Do you have a lot of space?");
            root.Yes.Yes = new DecisionNode("Recommended: Dog"); 
            root.Yes.No = new DecisionNode("Recommended: Cat");  
            root.No = new DecisionNode("Do you prefer low-maintenance pets?");
            root.No.Yes = new DecisionNode("Recommended: Fish"); 
            root.No.No = new DecisionNode("Recommended: Hamster"); 


            var currentNode = root;


          
            while (currentNode.Yes != null && currentNode.No != null)
            {
                Console.WriteLine(currentNode.Question); 
                string answer = Console.ReadLine().Trim().ToLower(); 


              
                if (answer == "yes")
                    currentNode = currentNode.Yes;
                else if (answer == "no")
                    currentNode = currentNode.No;
                else
                    Console.WriteLine("Please answer 'yes' or 'no'.");
            }


          
            Console.WriteLine(currentNode.Question);
        }
    }
}
