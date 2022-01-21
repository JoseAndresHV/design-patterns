using Animals.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Factories.Abstractions
{
    public interface IContinentFactory
    {
        public IHerbivore CreateHerbivore();
        public ICarnivore CreateCarnivore();
    }
}
