using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_List_of_Students_in_a_Classroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> students = new ObservableCollection<string>();

            students.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine("New student added: " + e.NewItems[0]);
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine("Student removed: " + e.OldItems[0]);

            };

            students.Add("Alice");
            students.Add("Bob");
            students.Remove("Alice");

        }
    }
}
