using Lab8_Composite_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_Visitor_
{
    public class CountSectionVisiter
    {
        public int Visit(MenuComp menu)
        {
            int count = 0;
            if (menu.GetType() == typeof(MenuSection))
            {
                count++;
            }
        }
    }
}
