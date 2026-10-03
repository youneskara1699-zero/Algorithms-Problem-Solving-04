using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        ObservableCollection<string> chatMessages = new ObservableCollection<string>();

        chatMessages.CollectionChanged += (sender, e) =>
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine($"New Message: {e.NewItems[0]}");
        };

        chatMessages.Add("Hello!");
        chatMessages.Add("How are you?");
   
    }
}

