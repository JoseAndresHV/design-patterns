using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsGame.WeaponsStrategies;

namespace WeaponsGame.CharacterContext
{
    public class Knight : Character
    {
        public Knight()
        {
            weapon = new Sword();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Knight");
        }
    }
}
