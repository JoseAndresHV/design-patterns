using PizzasFactory.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasFactory.Products.NYStyle
{
    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
