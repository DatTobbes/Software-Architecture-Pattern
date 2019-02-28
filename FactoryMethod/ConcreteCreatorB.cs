namespace FactoryMethod
{
    internal class ConcreteCreatorB : Creator
    {
        protected override Product FactoryMethod()
        {
            var concreteProductB = new ConcreteProductB();

            return concreteProductB;
        }
    }
}