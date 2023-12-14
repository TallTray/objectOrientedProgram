using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Iterator_
{
    public interface IIterator<T>
    {
        public T First();
        public T Current();
        public T Next();
        public bool IsDone();
    }
}
