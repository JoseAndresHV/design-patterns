using GumballMachine.States.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine.States
{
    public class SoldOutState : IState
    {
        private readonly Machine _machine;

        public SoldOutState(Machine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            throw new NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void InsertQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
