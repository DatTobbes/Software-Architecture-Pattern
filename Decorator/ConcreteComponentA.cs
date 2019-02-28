using System;

namespace Decorator
{
    internal class ConcreteComponentA: Component
    {
        public override void Operate()
        {
            Console.WriteLine("Contrete Component A operates");
        } 
    }
}
