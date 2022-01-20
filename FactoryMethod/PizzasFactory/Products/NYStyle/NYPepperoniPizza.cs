using PizzasFactory.Products.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzasFactory.Products.NYStyle
{
	public class NYPepperoniPizza : Pizza
	{
		public NYPepperoniPizza()
		{
			Name = "Chicago Style Pepperoni Pizza";
			Dough = "Extra Thick Crust Dough";
			Sauce = "Plum Tomato Sauce";

			Toppings.Add("Shredded Mozzarella Cheese");
			Toppings.Add("Black Olives");
			Toppings.Add("Spinach");
			Toppings.Add("Eggplant");
			Toppings.Add("Sliced Pepperoni");
		}
	}
}
