using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Representing_a_Social_Network
{
    internal class Program
    {
       class Person  
       {
            string Name { get; set; }
            public List<Person> Friends { get; set; } = new List<Person>();

            public Person(string name) 
            {
                Name = name;
            }

            public void PrintFriends(int depth, string indent = "")
            {
               if (depth == 0) return;

                Console.WriteLine(indent + Name);

                foreach (var Friend in Friends)
                {
                    Friend.PrintFriends(depth - 1, indent + "  ");
                }
            }
       }
        static void Main(string[] args)
        {
            var alice = new Person("Alice");
            var bob = new Person("Bob");
            var charlie = new Person("Charlie");
            var dave = new Person("Dave");


           
            alice.Friends.Add(bob); 
            alice.Friends.Add(charlie); 
            bob.Friends.Add(dave); 


           
            Console.WriteLine("Alice's Social Network:");
            alice.PrintFriends(2);

        }
    }
}
