namespace DesignMode.SimpleFactory
{
    public class SumFactory
    {
        public static Sum GetSum(SumType sumType)
        {
            return sumType switch
            {
                SumType.Plus => new Plus(),
                SumType.Minus => new Minus(),
                _ => new Plus(),
            };
        }
    }

    public enum SumType
    {
        Plus = 1, Minus = 2
    }
}
