using System;

namespace Decorator
{
    internal class ConcreteComponentB : Component
    {
        public override void Operate()
        {
            Console.WriteLine( "Contrete Component B operates" );
        }
    }
}