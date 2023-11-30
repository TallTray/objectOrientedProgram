using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Decorator_
{
    public class Lemon : CoffeDecorator
    {
        public Lemon(Coffe compnent) : base(compnent) { }
        public override int Price()
        {
            return Component.Price() + 2;
        }
    }
}
