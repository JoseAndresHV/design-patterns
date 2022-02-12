using GumballMachine.States.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine.States
{
    public class NoQuarterState : IState
    {
        private Machine _machine;

        public NoQuarterState(Machine machine)
        {
            _machine = machine;
        }
        public void Dispense()
        {
            Console.WriteLine("You need to pay first.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter.");
            _machine.State = _machine.GetHasQuarterState();
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }
    }
}
