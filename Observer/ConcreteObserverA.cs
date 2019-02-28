using System;

namespace Observer
{
    internal class ConcreteObserverA : IObserver
    {
        private readonly string myName;
        public ConcreteObserverA( string name )
        {
            myName = name;
        }
        public void Update( int state )
        {
            Console.WriteLine( $"{myName} from Type:{GetType()} updated with state: {state}" );
        }
    }
}