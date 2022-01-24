using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteLoader.Receivers
{
    public class Light
    {
        private int _level;
        public int Level { get { return _level; } }

        public void On()
        {
            _level = 100;
            Console.WriteLine("Light is on");
        }

        public void Off()
        {
            _level = 0;
            Console.WriteLine("Light is off");
        }

        public void Dim(int level)
        {
            _level = level;
            if (_level == 0)
            {
                Off();
            }
            else
            {
                Console.WriteLine($"Light is dimmed to { level }%");
            }
        }
    }
}
