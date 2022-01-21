using SimpleAbstractFactory.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstractFactory.Products
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string AnotherOperationB(IAbstractProductA collaborator)
        {
            var result = collaborator.OperationA();

            return $"The result of the B1 collaborating with the ({ result })";
        }

        public string OperationB()
        {
            return "The result of product B1.";
        }
    }
}
