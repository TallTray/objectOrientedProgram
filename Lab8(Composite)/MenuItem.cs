using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Composite_
{
    public class MenuItem : MenuComp
    {
        public string Name { get; init; }
        public bool IsVegan { get; init; }
        public MenuItem(string name, bool isVegan)
        {
            list = new();
            Name = name;
            IsVegan = isVegan;
        }
        public override void AddMenuComp(MenuComp menu)
        {
            throw new ArgumentException("MenuItem cannot contain any other objects of MenuComp type");
        }
        public override bool RemoveMenuComp(MenuComp menu)
        {
            return false;
        }
        public override void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
