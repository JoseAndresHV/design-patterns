using ConceptualCommand.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptualCommand.Commands
{
    public class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;
        public SimpleCommand(string payload)
        {
            _payload = payload;
        }
        public void Execute()
        {
            Console.WriteLine($"Simple command: Printing { _payload }");
        }
    }
}
