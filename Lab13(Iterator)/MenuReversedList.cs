using Lab8_Composite_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Iterator_
{
    public class MenuReversedList : IIterator<MenuItem>
    {
        private readonly List<MenuItem> _items;
        private int _index;
        public MenuReversedList(List<MenuItem> items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
            _index = _items.Count - 1;
        }

        public MenuItem Current()
        {
            return _items[_index];
        }
        public MenuItem Next()
        {
            if (_index != 0)
            {
                return _items[_index--];
            }
            else
            {
                throw new InvalidOperationException("Блюд больше нет");
            }
            
        }
    }
}
