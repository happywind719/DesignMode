using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.AbstractFactory.FactoryNo2
{
    public class ConcreteProductAFromFacNo2 : AbstractProductA
    {
        public override void ShowName()
        {
            Console.WriteLine("This is a ProductA from Factory No.2");
        }
    }
}
