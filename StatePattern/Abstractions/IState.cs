namespace StatePattern.Abstractions
{
    public interface IState
    {
        void InjectQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}