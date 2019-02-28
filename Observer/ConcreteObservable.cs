namespace Observer
{
    internal class ConcreteObservable : Observable
    {
        private int myState;

        public void SetState( int state )
        {
            myState = state;
            NotifyObserver( myState );
        }

        public int GetState() => myState;
    }
}