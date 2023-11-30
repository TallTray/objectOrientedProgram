using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Decorator_
{
    public class CoffeDecorator : Coffe
    {
        public Coffe Component { get; init; }
        public CoffeDecorator(Coffe component)
        {
            Component = component;
        }
        public override int Price()
        {
            return Component.Price();
        }
        public override void Print()
        {
            Component.Print();
        }
    }
}
