using System.Data.Common;

namespace DesignMode.AbstractFactory.FactoryNo2
{
    public class ConcreteFactoryNo2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductAFromFacNo2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductBFromFacNo2();
        }
    }
}