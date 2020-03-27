namespace PizzaFactoryConsole
{
    public class PizzeriaABoxFactory : IBoxFactory
    {
        public Box CreateBox()
        {
            return new RedBox();
        }
    }
}