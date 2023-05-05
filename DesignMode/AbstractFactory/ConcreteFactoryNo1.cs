using System.Data.Common;

namespace DesignMode.AbstractFactory
{
    public class ConcreteFactoryNo1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductAFromFacNo1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductBFromFacNo1();
        }
    }
}