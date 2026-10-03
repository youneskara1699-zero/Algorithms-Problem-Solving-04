using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Dynamic_Weather_Updates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> weatherUpdates = new ObservableCollection<string>();
            weatherUpdates.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Weather Update: {e.NewItems[0]}");
            };

            weatherUpdates.Add("New York: Sunny, 25°C");
            weatherUpdates.Add("London: Rainy, 15°C");



        }
    }
}
