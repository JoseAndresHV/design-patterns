using RemoteLoader.Commands.Fans;
using RemoteLoader.Commands.Lights;
using RemoteLoader.Invokers;
using RemoteLoader.Receivers;
using System;

namespace RemoteLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Invoker
            RemoteControl remoteControl = new RemoteControl();

            // Receivers
            var light = new Light();
            var fan = new Fan();

            // Commands
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);

            var fanOff = new FanOffCommand(fan);
            var fanLow = new FanLowCommand(fan);
            var fanMedium = new FanMediumCommand(fan);
            var fanHigh = new FanHighCommand(fan);

            // Setting commands
            remoteControl.SetCommand(0, lightOn, lightOff);
            remoteControl.SetCommand(1, fanLow, fanOff);
            remoteControl.SetCommand(2, fanHigh, fanMedium);

            // Invoker Actions
            remoteControl.OnButtonPushed(0);
            remoteControl.OffButtonPushed(0);
            remoteControl.OnButtonPushed(0);
            remoteControl.UndoButtonPushed();
            Console.WriteLine(remoteControl);


            remoteControl.OnButtonPushed(1);
            remoteControl.OnButtonPushed(2);
            remoteControl.UndoButtonPushed();
            Console.WriteLine(remoteControl);
        }
    }
}
