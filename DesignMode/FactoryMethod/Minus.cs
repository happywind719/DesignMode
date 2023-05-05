namespace DesignMode.FactoryMethod
{
    public class Minus : Sum
    {
        public override double GetResult()
        {
            return A - B;
        }
    }
}
