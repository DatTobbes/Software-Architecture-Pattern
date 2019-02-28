using System;

namespace Decorator
{
    internal static class Program
    {
        private static void Main()
        {
            Component concreteComponentA = new ConcreteComponentA();
            concreteComponentA.Operate();

            concreteComponentA = new ConcreteDecorator1( concreteComponentA );
            concreteComponentA.Operate();

            Component concreteDecorator3 = new ConcreteDecorator3( new ConcreteDecorator2( new ConcreteComponentB() ) );
            concreteDecorator3.Operate();

            Console.ReadKey();
        }
    }
}