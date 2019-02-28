namespace FactoryMethod
{
    internal class ConcreteCreatorA : Creator
    {
        protected override Product FactoryMethod()
        {
            var concreteProductA = new ConcreteProductA();
            //here you can add additional code for product A

            return concreteProductA;
        }
    }
}