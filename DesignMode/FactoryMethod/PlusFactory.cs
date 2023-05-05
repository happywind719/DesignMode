namespace DesignMode.FactoryMethod
{
    public class PlusFactory : ISumFactory
    {
        public Sum CreateSum()
        {
            return new Plus();
        }
    }
}
