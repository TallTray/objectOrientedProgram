using Lab8_Composite_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_Visitor_
{
    public abstract class Visitor
    {
        public abstract int Visit(MenuComp component,int count = 0);
    }
}
