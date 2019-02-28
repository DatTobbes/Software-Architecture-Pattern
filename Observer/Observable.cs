using System.Collections.Generic;

namespace Observer
{
    internal abstract class Observable
    {
        private readonly List<IObserver> myObserverList = new List<IObserver>();

        public void Register( IObserver observerToRegister )
        {
            myObserverList.Add( observerToRegister );
        }

        public void Unregister( IObserver oberserverToUnregister )
        {
            myObserverList.Remove( oberserverToUnregister );
        }

        public void NotifyObserver( int state )
        {
            foreach( var observer in myObserverList )
            {
                observer.Update( state );
            }
        }
    }
}