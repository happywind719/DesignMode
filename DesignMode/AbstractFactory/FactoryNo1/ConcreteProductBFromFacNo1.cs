using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.AbstractFactory.FactoryNo1
{
    public class ConcreteProductBFromFacNo1 : AbstractProductB
    {
        public override void ShowName()
        {
            Console.WriteLine("This is a ProductB from Factory No.1");
        }
    }
}
