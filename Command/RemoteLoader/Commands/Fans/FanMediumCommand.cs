using RemoteLoader.Commands.Base;
using RemoteLoader.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteLoader.Commands.Fans
{
    public class FanMediumCommand : ICommand
    {
        private Fan _fan;
        private FanSpeeds _prevSpeed;

        public FanMediumCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _prevSpeed = _fan.Speed;
            _fan.Medium();
        }

        public void Undo()
        {
            switch (_prevSpeed)
            {
                case FanSpeeds.OFF:
                    _fan.Off();
                    break;
                case FanSpeeds.LOW:
                    _fan.Low();
                    break;
                case FanSpeeds.MEDIUM:
                    _fan.Medium();
                    break;
                case FanSpeeds.HIGH:
                    _fan.High();
                    break;
                default:
                    break;
            }
        }
    }
}
