using PizzasFactory.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasFactory.Products.NYStyle
{
    public class NYClamPizza : Pizza
    {
        public NYClamPizza()
        {
            Name = "NY Style Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Fresh Clams from Long Island Sound");
        }
    }
}
