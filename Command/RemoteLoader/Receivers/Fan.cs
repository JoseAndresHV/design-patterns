using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteLoader.Receivers
{
    public enum FanSpeeds
    {
        OFF,
        LOW,
        MEDIUM,
        HIGH
    }

    public class Fan
    {
        private FanSpeeds _speed;
        public FanSpeeds Speed { get { return _speed; } }

        public Fan()
        {
            _speed = FanSpeeds.OFF;
        }

        public void Off()
        {
            _speed = FanSpeeds.OFF;
            Console.WriteLine("Fan is off");
        }

        public void Low()
        {
            _speed = FanSpeeds.LOW;
            Console.WriteLine("Fan is on low");
        }

        public void Medium()
        {
            _speed = FanSpeeds.MEDIUM;
            Console.WriteLine("Fan is on medium");
        }

        public void High()
        {
            _speed = FanSpeeds.HIGH;
            Console.WriteLine("Fan is on high");
        }
    }
}
