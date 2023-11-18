using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Adapter_
{
    public class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Утка крякает");
        }
        public virtual void Fly()
        {
            Console.WriteLine("Утка летит");
        }
    }
}
