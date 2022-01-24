using RemoteLoader.Commands.Base;
using RemoteLoader.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteLoader.Commands.Lights
{
    public class LightOnCommand : ICommand
    {
        private Light _light;
        private int _level;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _level = _light.Level;   
            _light.On();
        }

        public void Undo()
        {
            _light.Dim(_level);
        }
    }
}
