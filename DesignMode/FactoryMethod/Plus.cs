namespace DesignMode.FactoryMethod
{
    public class Plus : Sum
    {
        public override double GetResult()
        {
            return A + B;
        }
    }
}
