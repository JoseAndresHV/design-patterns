using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsGame.WeaponsStrategies;

namespace WeaponsGame.CharacterContext
{
    public class King : Character
    {
        public King()
        {
            weapon = new Sword();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a King");
        }
    }
}
