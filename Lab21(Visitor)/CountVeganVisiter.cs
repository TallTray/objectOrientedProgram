using Lab8_Composite_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_Visitor_
{
    internal class CountVeganVisiter : Visitor
    {
        public override int Visit(MenuComp menuComp, int count = 0)
        {
            int counter = count + (menuComp is MenuItem item && item.IsVegan ? 1 : 0);
            if (menuComp is MenuSection section)
            {
                foreach (var el in section.list)
                {
                    counter = Visit(menuComp, counter);
                }

            }
            else if (menuComp is Menu menu)
            {
                foreach (var el in menu.list)
                {
                    counter = Visit(menuComp, counter);
                }
            }
            return counter;
        }
    }
}
