namespace PizzaFactoryConsole
{
    public class PizzeriaBBoxFactory : IBoxFactory
    {
        public Box CreateBox()
        {
            return new GreenBox();
        }
    }
}