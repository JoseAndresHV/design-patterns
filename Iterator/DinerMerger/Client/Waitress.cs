using DinerMerger.Aggregates.Base;
using DinerMerger.Aggregates.Items;
using DinerMerger.Iterators.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger.Client
{
    class Waitress
    {
        IMenu _pancakeHouseMenu;
        IMenu _dinerMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }
        
        public void PrintMenu()
        {
            IIterator pancakeIterator = (IIterator)_pancakeHouseMenu.GetEnumerator();
            IIterator dinerIterator = (IIterator)_dinerMenu.GetEnumerator();
            PrintMenu(pancakeIterator);
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IEnumerator iterator)
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(iterator.GetType().Name);

            var item = iterator.Current;
            Console.WriteLine(item);

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }
    }
}
