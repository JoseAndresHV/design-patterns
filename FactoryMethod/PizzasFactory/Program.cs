using PizzasFactory.Creators;
using PizzasFactory.Creators.Abstractions;
using PizzasFactory.Products.Abstractions;
using System;

namespace PizzasFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            pizza = chicagoStore.OrderPizza("cheese");

            pizza = nyStore.OrderPizza("pepperoni");
            pizza = chicagoStore.OrderPizza("pepperoni");
        }
    }
}
