using PizzasFactory.Creators.Abstractions;
using PizzasFactory.Products.Abstractions;
using PizzasFactory.Products.ChicagoStyle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasFactory.Creators
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoCheesePizza();
                case "clam":
                    return new ChicagoClamPizza();
                case "pepperoni":
                    return new ChicagoPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
