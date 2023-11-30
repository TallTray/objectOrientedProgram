using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Decorator_
{
    public class Syrop : CoffeDecorator
    {
        public Syrop(Coffe compnent) : base(compnent) { }
        public override int Price()
        {
            return Component.Price() + 3;
        }
    }
}
