using System;

namespace Strategy
{
    internal static class Program
    {
        static void Main()
        {
            var context = new Context( new ConcreteStrategyA() );

            context.Execute();

            context.SetStrategy( new ConcreteStrategyB() );
            context.Execute();

            Console.ReadKey();
        }
    }
}