using PizzasFactory.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasFactory.Creators.Abstractions
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string type);
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            Console.WriteLine($"{ pizza.Name } ordered.");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

    }
}
