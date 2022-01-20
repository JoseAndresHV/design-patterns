using SimpleFactoryMethod.Creators.Abstractions;
using SimpleFactoryMethod.Products;
using SimpleFactoryMethod.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethod.Creators
{
    class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
