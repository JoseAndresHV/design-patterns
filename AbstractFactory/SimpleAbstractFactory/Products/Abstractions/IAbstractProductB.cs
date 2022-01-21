using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAbstractFactory.Products.Abstractions
{
    public interface IAbstractProductB
    {
        public string OperationB();
        public string AnotherOperationB(IAbstractProductA collaborator);
    }
}
