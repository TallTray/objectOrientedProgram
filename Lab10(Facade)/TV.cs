using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Facade_
{
    public class TV
    {
        public void TurnOn()
        {
            Console.WriteLine("Телевизор включен");
        }
        public void TurnOff()
        {
            Console.WriteLine("Телевизор выключен");
        }
        public void ChangeMode()
        {
            Console.WriteLine("Телевизор сменил режим работы");
        }
    }
}
