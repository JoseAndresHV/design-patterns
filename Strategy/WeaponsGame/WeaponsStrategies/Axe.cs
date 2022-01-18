using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsGame.WeaponsStrategies
{
    public class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Chopping with an axe...");
        }
    }
}
