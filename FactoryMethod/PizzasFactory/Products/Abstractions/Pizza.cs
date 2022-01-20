using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasFactory.Products.Abstractions
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }

        public List<string> Toppings = new();

        public void Prepare()
        {
            Console.WriteLine($"Preparing { Name }...");
            Console.WriteLine("Tossing dough... ");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            Toppings.ForEach(t => Console.Write($"{ t }, "));
            Console.WriteLine();
        }

        public void Bake()
        {
            Console.WriteLine("Baking...");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting into diagonal slices...");
        }

        public void Box()
        {
            Console.WriteLine("Placing pizza in PizzaStore box...");
        }

        public override string ToString()
        {
            StringBuilder display = new();
            display.Append($"{ Name }\n");
            display.Append($"{ Dough }\n");
            display.Append($"{ Sauce }\n");
            Toppings.ForEach(t => display.Append($"{ t }, "));

            return display.ToString();
        }
    }
}
