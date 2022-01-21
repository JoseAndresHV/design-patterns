using Animals.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Products.Carnivores
{
    public class Lion : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine("Lion roaring...");
            Console.WriteLine($"{ GetType().Name } eats { herbivore.GetType().Name }\n");
        }
    }
}
