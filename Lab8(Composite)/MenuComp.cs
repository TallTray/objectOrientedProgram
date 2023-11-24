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
        public virtual void Print()
        {
            list.ForEach(x => x.Print());
        }
        public virtual void AddMenuComp(MenuComp menu)
        {
            _ = menu ?? throw new ArgumentNullException(nameof(menu));
            if ((Menu)menu != null)
            {
                throw new InvalidOperationException("Menu cannot contain another menu");
            }
            list.Add(menu);
        }
        public virtual bool RemoveMenuComp(MenuComp menu)
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
    }
}
