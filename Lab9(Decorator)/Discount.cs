using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Decorator_
{
    public class Discount: CoffeDecorator
    {
        public int Percent { get; init; }
        public Discount(Coffe compnent, int percent) : base(compnent) 
        {
            Percent = percent;
        }
        public override int Price()
        {
            return Component.Price() - Component.Price()*Percent/100;
        }
    }
}
