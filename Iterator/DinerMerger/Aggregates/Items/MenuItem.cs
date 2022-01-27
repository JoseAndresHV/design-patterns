using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger.Aggregates.Items
{
    public class MenuItem
    {
        string _name;
        string _description;
        bool _vegetarian;
        double _price;

        public string Name
        {
            get { return _name; }
        }
        public string Description
        {
            get { return _description; }
        }
        public bool Vegetarian
        {
            get { return _vegetarian; }
        }
        public double Price
        {
            get { return _price; }
        }

        public MenuItem(string name, string description,
                        bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Name: { _name }");
            builder.AppendLine($"Description: { _description }");
            builder.AppendLine($"Vegetarian: { _vegetarian }");
            builder.AppendLine($"Price: { _price }");
            return builder.ToString();
        }
    }
}
