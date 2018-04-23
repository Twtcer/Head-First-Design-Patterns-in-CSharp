using System;
using StatePattern.Abstractions;
using StatePattern.Machines;

namespace StatePattern.States
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;
        private readonly Random _random = new Random();

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InjectQuarter()
        {
            Console.WriteLine("You can’t insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.State = _gumballMachine.NoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            var winner = _random.Next(0, 10);
            if (winner == 0 && _gumballMachine.Count > 1)
            {
                _gumballMachine.State = _gumballMachine.WinnerState;
            }
            else
            {
                _gumballMachine.State = _gumballMachine.SoldState;
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            return "just being inserted with a quarter";
        }
    }
}
