using System;
using WeaponsGame.CharacterContext;
using WeaponsGame.WeaponsStrategies;

namespace WeaponsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Character king = new King();
            king.Display();
            king.Fight();
            king.SetWeapon(new Axe());
            king.Fight();

            Character queen = new Queen();
            queen.Display();
            queen.Fight();
            queen.SetWeapon(new Knife());
            queen.Fight();
        }
    }
}
