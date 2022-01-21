using Animals.Factories.Abstractions;
using Animals.Products.Abstractions;
using Animals.Products.Carnivores;
using Animals.Products.Herbivores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Factories
{
    public class AmericaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
