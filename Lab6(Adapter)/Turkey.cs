using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Adapter_
{
    public class Turkey
    {
        public void Cackle()
        {
            Console.WriteLine("Индюк гогочет");
        }
        public void Walk()
        {
            Console.WriteLine("Индюк идет");
        }
    }
}
