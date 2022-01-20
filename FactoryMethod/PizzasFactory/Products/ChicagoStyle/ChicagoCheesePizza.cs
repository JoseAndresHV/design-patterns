using PizzasFactory.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasFactory.Products.ChicagoStyle
{
    public class ChicagoCheesePizza : Pizza
    {
        public ChicagoCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting into square slices...");
        }
    }
}