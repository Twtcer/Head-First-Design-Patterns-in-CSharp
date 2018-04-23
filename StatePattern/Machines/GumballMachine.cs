using System;
using StatePattern.Abstractions;
using StatePattern.States;

namespace StatePattern.Machines
{
    public class GumballMachine
    {
        public IState SoldOutState { get; set; }
        public IState NoQuarterState { get; set; }
        public IState HasQuarterState { get; set; }
        public IState SoldState { get; set; }
        public IState WinnerState { get; set; }
        public IState State { get; set; }
        public int Count { get; set; }

        public GumballMachine(int numberOfGumballs)
        {
            SoldState = new SoldState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldOutState = new SoldOutState(this);
            WinnerState = new WinnerState(this);

            Count = numberOfGumballs;
            if (Count > 0)
            {
                State = NoQuarterState;
            }
        }

        public void InjectQuarter()
        {
            State.InjectQuarter();
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

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count--;
            }
        }

        public void Refill(int count)
        {
            Count += count;
            State = NoQuarterState;
        }

        public override string ToString()
        {
            return $"Mighty Gumball, Inc.\nC#-enabled Standing Gumball Model #2018\nInventory: {Count} gumballs\nThe machine {State} ";
        }
    }
}
