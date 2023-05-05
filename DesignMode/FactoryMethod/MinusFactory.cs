namespace DesignMode.FactoryMethod
{
    public class MinusFactory : ISumFactory
    {
        public Sum CreateSum()
        {
            return new Minus();
        }
    }
}
