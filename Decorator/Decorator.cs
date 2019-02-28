namespace Decorator
{
    abstract class Decorator : Component
    {
        private Component myComponent;

        public Decorator( Component component )
        {
            myComponent = component;
        }

    }
}
