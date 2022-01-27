using DinerMerger.Aggregates.Base;
using DinerMerger.Aggregates.Items;
using DinerMerger.Iterators;
using System.Collections;

namespace DinerMerger.Aggregates
{
    public class DinerMenu : IMenu
    {
        const int MAX_ITEMS = 6;
        int _itemsCount = 0;
        MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT",
                "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day",
                "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog",
                "A hot dog, with sauerkraut, relish, onions, topped with cheese",
                false, 3.05);
            AddItem("Steamed Veggies and Brown Rice",
                "Steamed vegetables over brown rice", true, 3.99);
            AddItem("Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true, 3.89);
        }

        public void AddItem(string name, string description,
                            bool vegetarian, double price)
        {
            MenuItem menuItem = new(name, description, vegetarian, price);
            if (_itemsCount < MAX_ITEMS)
            {
                _menuItems[_itemsCount] = menuItem;
                _itemsCount++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}
