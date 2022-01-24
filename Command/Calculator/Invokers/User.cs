using CalculatorExample.Commands.Base;
using CalculatorExample.Commands;
using CalculatorExample.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExample.Invokers
{
    public class User
    {
        Calculator calculator = new Calculator();
        List<ICommand> commands = new List<ICommand>();
        int current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine($"\nRedo { levels } levels");

            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    ICommand command = commands[current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine($"\nUndo { levels } levels");

            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    ICommand command = commands[--current];
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            ICommand command = new CalculatorCommand(calculator, @operator, operand);
            command.Execute();

            commands.Add(command);
            current++;
        }
    }
}
