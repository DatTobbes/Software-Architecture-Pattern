using System;

namespace Decorator
{
    internal class ConcreteDecorator1 : Decorator
    {
        public ConcreteDecorator1( Component component ) : base( component ) {}

        public override void Operate()
        {
            Console.WriteLine( "Concrete Decorator 1 operates" );
        }
    }
}