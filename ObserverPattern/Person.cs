using System;

namespace ObserverPattern
{
    public class Person
    {
        public event EventHandler<FallsIllEventArgs> FallsIll;

        public void OnFallsIll()
        {
            FallsIll?.Invoke(this, new FallsIllEventArgs("China Beijing"));
        }

    }
}