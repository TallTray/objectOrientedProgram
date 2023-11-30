using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Decorator_
{
    public  class Cappuccino: Coffe
    {
        public override int Price()
        {
            return 5;
        }
        public override void Print()
        {
            Console.WriteLine("Капучино");
        }
    }
}
