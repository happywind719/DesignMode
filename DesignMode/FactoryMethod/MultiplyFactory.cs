namespace DesignMode.FactoryMethod
{
    public class MultiplyFactory : ISumFactory
    {
        public Sum CreateSum()
        {
            return new Multiply();
        }
    }
}
