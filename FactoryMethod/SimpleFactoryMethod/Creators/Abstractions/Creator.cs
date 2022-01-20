using SimpleFactoryMethod.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethod.Creators.Abstractions
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            return $"Creator: The same creator's code has just worked with { product.Operation()} ";
        }
    }
}
