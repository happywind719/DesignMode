namespace DesignMode.SimpleFactory
{
    public class Sum
    {
        public double A { get; set; }
        public double B { get; set; }  
        public Sum() { }

        public virtual double GetResult()
        {
            return 0;
        }
    }
}
