using System;

namespace Strategy
{
    public class ConcreteStrategyA : IStrategy
    {
        public void ExecuteAlgortihm()
        {
            Console.WriteLine( GetType() );
        }
    }
}