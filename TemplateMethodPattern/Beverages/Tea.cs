using System;
using TemplateMethodPattern.Abstractions;

namespace TemplateMethodPattern.Beverages
{
    public class Tea: CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
