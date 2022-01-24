using DuckTestDrive.Adaptee;
using DuckTestDrive.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckTestDrive.Adapter
{
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Fly()
        {
            _turkey.Fly();
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
