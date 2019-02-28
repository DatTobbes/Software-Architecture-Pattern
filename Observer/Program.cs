using System;

namespace Observer
{
    internal static class Program
    {
        static void Main( string[] args )
        {
            ConcreteObservable concreteObservable = new ConcreteObservable();
            concreteObservable.Register( new ConcreteObserverA( "First" ) );
            concreteObservable.Register( new ConcreteObserverB( "Second" ) );
            var observerToRegister = new ConcreteObserverB( "Third" );
            concreteObservable.Register( observerToRegister );

            concreteObservable.NotifyObserver( 24 );
            concreteObservable.Unregister( observerToRegister );
            Console.WriteLine( "==================================" );
            concreteObservable.NotifyObserver( 42 );

            Console.ReadKey();
        }
    }
}