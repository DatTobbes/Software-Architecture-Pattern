namespace Strategy
{
    internal class Context
    {
        private IStrategy myStrategy;

        public Context( IStrategy strategy )
        {
            myStrategy = strategy;
        }

        public void Execute()
        {
            myStrategy.ExecuteAlgortihm();
        }

        public void SetStrategy( IStrategy strategy ) => myStrategy = strategy;

        public IStrategy GetStrategy() => myStrategy;
    }
}