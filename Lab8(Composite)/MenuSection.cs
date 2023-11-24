using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Composite_
{
    public class MenuSection : MenuComp
    {
        public string Name { get; init; }
        public MenuSection(string name)
        {
            list = new();
            Name = name;
        }
        public override void Print()
        {
            Console.WriteLine(Name);
            base.Print();
        }
    }
}
