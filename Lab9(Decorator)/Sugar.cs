using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Decorator_
{
    public class Sugar : CoffeDecorator
    {
        public Sugar(Coffe compnent) : base(compnent) { }
        public override int Price()
        {
            return Component.Price() + 1;
        }
    }
}
