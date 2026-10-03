using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart_for_an_E_commerce_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> shoppingcart = new ObservableCollection<string>();

            shoppingcart.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine("New item added: " + e.NewItems[0]);

                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine("Old item removed: " + e.OldItems[0]);
            };

            shoppingcart.Add("Laptop");
            shoppingcart.Add("Mouse");
            shoppingcart.Remove("Mouse");

        }
    }
}
