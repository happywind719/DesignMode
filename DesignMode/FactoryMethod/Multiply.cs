namespace DesignMode.FactoryMethod
{
    public class Multiply : Sum
    {
        public override double GetResult()
        {
            return A * B;
        }
    }
}
