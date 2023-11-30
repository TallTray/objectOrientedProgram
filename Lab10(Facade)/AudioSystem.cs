using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Facade_
{
    public class AudioSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Аудио система включена");
        }
        public void TurnOff()
        {
            Console.WriteLine("Аудио система выключена");
        }
    }
}
