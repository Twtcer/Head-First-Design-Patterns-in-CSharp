using System;
using StatePattern.Abstractions;
using StatePattern.Machines;

namespace StatePattern.States
{
    public class WinnerState: IState
    {
        private readonly GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InjectQuarter()
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER! You get two balls for you quarter");
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.State = _gumballMachine.SoldOutState;
            }
            else
            {
                _gumballMachine.ReleaseBall();
                if (_gumballMachine.Count > 0)
                {
                    _gumballMachine.State = _gumballMachine.NoQuarterState;
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _gumballMachine.State = _gumballMachine.SoldOutState;
                }
            }
        }

        public override string ToString()
        {
            return "just sold 2 gumballs";
        }
    }
}
