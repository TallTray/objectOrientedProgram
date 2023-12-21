using Lab8_Composite_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Lab21_Visitor_
{
    public class CountSectionVisiter:Visitor
    {
        public override int Visit(MenuComp menuComp,int count = 0)
        {
            int counter = count;
            if (menuComp is MenuSection section)
            {
                foreach(var el in section.list)
                {
                    counter = Visit(menuComp, counter+1);
                }
                
            }
            else if (menuComp is Menu menu)
            {
                foreach (var el in menu.list)
                {
                    counter = Visit(menuComp, counter + 1);
                }
            }
            return counter;
        }
    }
}
