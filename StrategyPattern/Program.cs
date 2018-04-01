using System;
using StrategyPattern.Client;
using StrategyPattern.Core;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new TextProcessor();
            p.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(p);
            Console.ReadKey();

            p.Clear();
            p.SetListStrategy(OutputFormat.Markdown);
            p.AppendList(new [] { "foo", "bar", "baz" });
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
