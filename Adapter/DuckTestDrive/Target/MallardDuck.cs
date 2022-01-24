using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckTestDrive.Target
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Quack");
        }

        public void Quack()
        {
            Console.WriteLine("Flying...");
        }
    }
}
