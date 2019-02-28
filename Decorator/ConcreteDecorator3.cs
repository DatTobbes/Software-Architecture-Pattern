using System;

namespace Decorator {
    internal class ConcreteDecorator3 : Decorator
    {
        public ConcreteDecorator3( Component component ) : base( component ) {}

        public override void Operate()
        {
            Console.WriteLine( $"Concrete Decorator 3 operates and has an new Operation {NewOperation()} " );
        }

        private int NewOperation()
        {
            Random rnd = new Random();
            return rnd.Next( 0, 100 );
        }
    }
}