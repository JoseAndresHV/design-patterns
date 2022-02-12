using GumballMachine.States;
using GumballMachine.States.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine
{
    public class Machine
    {
        IState _soldOutState;
        IState _noQuarterState;
        IState _hasQuarterState;
        IState _soldState;

        public IState State { get; set; }
        int _count = 0;

        public Machine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);

            _count = numberGumballs;
            if (numberGumballs > 0)
            {
                State = _noQuarterState;
            }
            else
            {
                State = _soldOutState;
            }
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");

            if (_count > 0)
            {
                _count--;
            }
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}
