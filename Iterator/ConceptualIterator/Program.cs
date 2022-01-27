using System;

namespace ConceptualIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            collection.ReverseDirection();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            collection.ReverseDirection();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
