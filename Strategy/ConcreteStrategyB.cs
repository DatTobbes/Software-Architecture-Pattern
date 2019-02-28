using System;

namespace Strategy
{
    public class ConcreteStrategyB:IStrategy {
        public void ExecuteAlgortihm()
        {
            Console.WriteLine( GetType() );
        }
    }
}