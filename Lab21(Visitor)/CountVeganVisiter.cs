using Lab8_Composite_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_Visitor_
{
    internal class CountVeganVisiter
    {
        public int Visit(MenuComp menu)
        {
            int count = 0;
            if (menu.GetType() == typeof(MenuItem) && ((MenuItem)menu).IsVegan)
            {
                count++;
            }
        }
    }
}
