using RemoteLoader.Commands.Base;
using RemoteLoader.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteLoader.Commands.Lights
{
    public class LightOffCommand : ICommand
    {
        private Light _light;
        private int _level;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _level = _light.Level;
            _light.Off();
        }

        public void Undo()
        {
            _light.Dim(_level);
        }
    }
}
