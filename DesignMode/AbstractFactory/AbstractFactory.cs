using System.Data.Common;

namespace DesignMode.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB();
    }
}