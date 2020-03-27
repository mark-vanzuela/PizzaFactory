namespace PizzaFactoryConsole
{
    public abstract class Box
    {
        public abstract string GetBoxColor();
    }

    public class RedBox : Box
    {
        public override string GetBoxColor()
        {
            return "Red";
        }
    }

    public class GreenBox : Box
    {
        public  override string GetBoxColor()
        {
            return "Green";
        }
    }
}