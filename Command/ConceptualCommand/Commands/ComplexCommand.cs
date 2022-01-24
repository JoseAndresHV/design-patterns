using ConceptualCommand.Commands.Base;
using ConceptualCommand.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptualCommand.Commands
{
    public class ComplexCommand : ICommand
    {
        private Receiver _reciever;
        private string _a;
        private string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _reciever = receiver;
            _a = a;
            _b = b;
        }

        public void Execute()
        {
            _reciever.DoSomething(_a);
            _reciever.DoSomethingElse(_b);
        }
    }
}
