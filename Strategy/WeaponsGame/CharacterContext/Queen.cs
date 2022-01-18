using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsGame.WeaponsStrategies;

namespace WeaponsGame.CharacterContext
{
    public class Queen : Character
    {
        public Queen()
        {
            weapon = new BowAndArrow();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Queen");
        }
    }
}
