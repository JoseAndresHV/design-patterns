using RemoteLoader.Commands;
using RemoteLoader.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteLoader.Invokers
{
    public class RemoteControl
    {
        private const int _SLOTS = 3;
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[_SLOTS];
            _offCommands = new ICommand[_SLOTS];

            var noCommand = new NoCommand();
            for (int i = 0; i < _SLOTS; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append("\n ->Remote Control\n");
            for (int i = 0; i < _SLOTS; i++)
            {
                stringBuilder.Append($"[slot { i }] { _onCommands[i].GetType().Name } | [slot { i }] { _offCommands[i].GetType().Name }\n");
            }
            stringBuilder.Append($"[Undo] { _undoCommand.GetType().Name }\n");
            return stringBuilder.ToString();
        }
    }
}
