using System;
using StatePattern.Machines;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalColor = Console.ForegroundColor;

            var machine = new GumballMachine(5);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(machine);

            Console.ForegroundColor = originalColor;
            Console.WriteLine();
            machine.InjectQuarter();
            machine.TurnCrank();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(machine);

            Console.ForegroundColor = originalColor;
            Console.WriteLine();
            machine.InjectQuarter();
            machine.TurnCrank();
            machine.InjectQuarter();
            machine.TurnCrank();
            machine.InjectQuarter();
            machine.TurnCrank();
            machine.InjectQuarter();
            machine.TurnCrank();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(machine);

            Console.ReadKey();
        }
    }
}
