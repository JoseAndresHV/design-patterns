using GumballMachine.States.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine.States
{
    public class SoldState : IState
    {
        private readonly Machine _machine;

        public SoldState(Machine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            _machine.releaseBall();

            if (_machine.GetCount() > 0)
            {
                _machine.State = _machine.GetNoQuarterState();
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs");
                _machine.State = _machine.GetSoldOutState();
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }
    }
}
