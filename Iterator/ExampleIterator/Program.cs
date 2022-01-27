using System;

namespace ExampleIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new();
            collection[0] = new Item("Item1");
            collection[1] = new Item("Item1");
            collection[2] = new Item("Item2");
            collection[3] = new Item("Item3");
            collection[4] = new Item("Item4");

            Iterator iterator = collection.CreateIterator();
            iterator.Step = 2;

            for (Item item = iterator.Fist();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
