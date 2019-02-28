namespace FactoryMethod
{
    internal abstract class Creator
    {
        public Product CreateProduct()
        {
            Product product = FactoryMethod();

            product.State = 23;
            product.Prepare();

            return product;
        }

        protected abstract Product FactoryMethod();
    }
}