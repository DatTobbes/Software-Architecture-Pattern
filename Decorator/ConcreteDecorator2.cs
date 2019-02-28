using System;

namespace Decorator {
    internal class ConcreteDecorator2 : Decorator
    {
        private int myInt;

        public ConcreteDecorator2( Component component ) : base( component )
        {
            myInt = 1234567;
        }

        public override void Operate()
        {
            Console.WriteLine( $"Concrete Decorator 2 operates and has an state {myInt}" );
        }
    }
}