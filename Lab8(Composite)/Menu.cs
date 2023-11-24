using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Composite_
{
    public class Menu : MenuComp
    {

        public Menu() 
        {
            list = new();
        }

        public override void Print()
        {
            Console.WriteLine("Меню:");
            base.Print();
        }
    }
}
