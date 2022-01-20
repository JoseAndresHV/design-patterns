using PizzasFactory.Creators.Abstractions;
using PizzasFactory.Products.Abstractions;
using PizzasFactory.Products.NYStyle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasFactory.Creators
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYCheesePizza();
                case "clam":
                    return new NYClamPizza();
                case "pepperoni":
                    return new NYPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
