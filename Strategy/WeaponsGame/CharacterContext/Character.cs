using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsGame.WeaponsStrategies;

namespace WeaponsGame.CharacterContext
{
    public abstract class Character
    {
        protected IWeapon weapon;

        public abstract void Display();

        public void Fight()
        {
            weapon.UseWeapon();
        }

        public void SetWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
            Console.WriteLine("Weapon changed...");
        }
    }
}
