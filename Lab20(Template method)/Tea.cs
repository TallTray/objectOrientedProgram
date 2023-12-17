using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_Template_method_
{
    public class Tea : DrinkBehavior
    {
        protected override void AddComponents()
        {
            Console.WriteLine("Добавили корицу");
        }

        protected override void Brew()
        {
            Console.WriteLine("Заварили чай");
        }
    }
}
