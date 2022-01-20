using SimpleFactoryMethod.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethod.Products
{
    public class ConcreteProductB : IProduct
    {
        public string Operation()
        {
            return "Result of ConcreteProductB";
        }
    }
}
