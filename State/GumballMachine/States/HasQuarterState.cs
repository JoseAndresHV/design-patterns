using GumballMachine.States.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine.States
{
    public class HasQuarterState : IState
    {
        private readonly Machine _machine;

        public HasQuarterState(Machine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _machine.State = _machine.GetNoQuarterState();
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            _machine.State = _machine.GetSoldState();
        }
    }
}
