using SimpleAbstractFactory.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstractFactory.Products
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string OperationA()
        {
            return "The result of product A2.";
        }
    }
}
