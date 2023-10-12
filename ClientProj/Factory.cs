using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProj
{
    abstract class Factory
    {
        public abstract ProductA CreateProductA();

        public abstract ProductB CreateProductB();
    }
}
