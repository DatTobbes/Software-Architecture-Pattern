using System;

namespace FactoryMethod
{
    internal static class Program
    {
        /// <summary>
        /// https://www.philipphauer.de/study/se/design-pattern/factory-method.php
        /// </summary>
        static void Main()
        {
            Creator creator = new ConcreteCreatorA();
            var product = creator.CreateProduct();
            Console.WriteLine( product.GetPrice() );

            Console.ReadKey();
        }
    }
}