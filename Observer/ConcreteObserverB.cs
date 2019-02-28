using System;

namespace Observer
{
    internal class ConcreteObserverB : IObserver
    {
        private readonly string myName;

        public ConcreteObserverB( string name )
        {
            myName = name;
        }

        public void Update( int state )
        {
            Console.WriteLine( $"{myName} from Type:{this.GetType()} updated with state: {state}" );
        }
    }
}