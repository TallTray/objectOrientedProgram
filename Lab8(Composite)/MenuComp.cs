using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Composite_
{
    public abstract class MenuComp
    {
        protected List<MenuComp> list { get; init; }
        public abstract void Print();
        public abstract void AddMenuComp(MenuComp menu);
        public abstract bool RemoveMenuComp(MenuComp menu);
    }
}
