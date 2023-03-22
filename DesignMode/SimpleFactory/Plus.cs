namespace DesignMode.SimpleFactory
{
    public class Plus : Sum
    {
        public override double GetResult()
        {
            return A + B;
        }
    }
}
