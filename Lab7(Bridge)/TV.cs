using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Bridge_
{
    public class TV : IDevice
    {
        public ushort Power { get; private set; }
        public ushort Mode { get; private set; }
        public void On()
        {
            Console.WriteLine("Телевизор включен");
        }
        public void Off()
        {
            Console.WriteLine("Телевизор выключен");
        }
        public void SetPower(ushort power)
        {
            Power = power;
            Console.WriteLine("Громкость телевизора на уровне " + Power);
        }
        public void SetMode(ushort mode)
        {
            Mode = mode;
            Console.WriteLine("Канал телевизора переключен на " +  Mode);
        }
    }
}
