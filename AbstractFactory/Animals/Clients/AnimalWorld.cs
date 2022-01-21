using Animals.Factories.Abstractions;
using Animals.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Clients
{
    public class AnimalWorld
    {
        private IHerbivore _herbivore;
        private ICarnivore _carnivore;

        public AnimalWorld(IContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
