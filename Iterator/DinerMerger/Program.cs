using DinerMerger.Aggregates;
using DinerMerger.Aggregates.Base;
using DinerMerger.Aggregates.Items;
using DinerMerger.Client;
using System;
using System.Collections.Generic;

namespace DinerMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu pancakeHouseMenu = new PancakeHouseMenu();
            IMenu dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.PrintMenu();
        }
    }
}
