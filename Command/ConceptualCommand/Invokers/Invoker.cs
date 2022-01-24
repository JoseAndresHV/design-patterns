using ConceptualCommand.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptualCommand.Invokers
{
    public class Invoker
    {
        private ICommand _onStart;
        private ICommand _onFinish;

        public ICommand OnStart { set { _onStart = value; } }
        public ICommand OnFinish { set { _onFinish = value; } }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Beginning...");

            if (_onStart is ICommand)
            {
                _onStart.Execute();
            }

            Console.WriteLine("Invoker: Doing something important...");
            Console.WriteLine("Invoker: Finishing...");

            if (_onFinish is ICommand)
            {
                _onFinish.Execute();
            }
        }
    }
}
