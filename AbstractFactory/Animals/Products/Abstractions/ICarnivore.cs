using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Products.Abstractions
{
    public interface ICarnivore
    {
        public void Eat(IHerbivore herbivore); 
    }
}
