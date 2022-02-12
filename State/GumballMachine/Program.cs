using GumballMachine;

Machine machine = new Machine(6);
machine.InsertQuarter();
machine.TurnCrank();

machine.InsertQuarter();
machine.InsertQuarter();
machine.TurnCrank();