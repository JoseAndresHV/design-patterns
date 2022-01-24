using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExample.Receivers
{
    public class Calculator
    {
        int curr = 0;
        
        public void Operation(char @operator, int operand)
        {
            int temp = curr;

            switch (@operator)
            {
                case '+': 
                    curr += operand;
                    break;
                case '-':
                    curr -= operand;
                    break;
                case '*':
                    curr *= operand;
                    break;
                case '/':
                    curr /= operand;
                    break;
                default:
                    Console.WriteLine("Syntax Error");
                    return;
            }
            Console.WriteLine($"{ temp } { @operator } { operand } = { curr }");
        }
    }
}
