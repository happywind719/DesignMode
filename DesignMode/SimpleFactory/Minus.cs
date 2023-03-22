namespace DesignMode.SimpleFactory
{
    public class Minus : Sum
    {
        public override double GetResult()
        {
            return A - B;
        }
    }
}
