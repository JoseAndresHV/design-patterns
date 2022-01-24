using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckTestDrive.Adaptee
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Short Fly...");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}
