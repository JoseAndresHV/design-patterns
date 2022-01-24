using CalculatorExample.Commands.Base;
using CalculatorExample.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExample.Commands
{
    public class CalculatorCommand : ICommand
    {
        private char _operator;
        private int _operand;
        Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;
        }

        public void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default:
                    throw new
             ArgumentException("@operator");
            }
        }
    }
}
