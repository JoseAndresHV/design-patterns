using System;

namespace BeverageTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new();
            Coffee coffee = new();

            tea.PrepareRecipe();

            Console.WriteLine(new string('-', 50));

            coffee.PrepareRecipe();
        }
    }
}
