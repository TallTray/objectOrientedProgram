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
        public override void AddMenuComp(MenuComp menu)
        {
            _ = menu ?? throw new ArgumentNullException(nameof(menu));
            if ((Menu)menu != null)
            {
                throw new InvalidOperationException("Menu cannot contain another menu");
            }
            list.Add(menu);
        }
        public override bool RemoveMenuComp(MenuComp menu)
        {
            _ = menu ?? throw new ArgumentNullException(nameof(menu));
            if (list.Contains(menu))
            {
                list.Remove(menu);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Print()
        {
            Console.WriteLine(Name);
            list.ForEach(x => x.Print());
        }
    }
}
