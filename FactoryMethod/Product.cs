using System;

namespace FactoryMethod
{
    public abstract class Product
    {
        private int myBasisState;

        public void Prepare()
        {
            Console.WriteLine($"preparing gerneral product");
        }

        public int State
        {
            get => myBasisState;
            set => myBasisState = value;
        }

        public abstract int GetPrice();
    }
}

