using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.AbstractFactory.FactoryNo2
{
    public class ConcreteProductBFromFacNo2 : AbstractProductB
    {
        public override void ShowName()
        {
            Console.WriteLine("This is a ProductB from Factory No.2");
        }
    }
}
