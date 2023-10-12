using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClientProj
{
    internal class ConcreteFactory1 : Factory
    {
        public override ProductA CreateProductA()
        {
            return new ProductA1();
        }
        public override ProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
