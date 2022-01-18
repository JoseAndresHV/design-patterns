using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsGame.WeaponsStrategies
{
    public class Knife : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cutting with a knife...");
        }
    }
}
