

namespace Lab7_Bridge_
{
    public class Conditioner : IDevice
    {
        public ushort Power { get; private set; }
        public ushort Mode { get; private set; }
        public void On()
        {
            Console.WriteLine("Кондиционер включен");
        }
        public void Off()
        {
            Console.WriteLine("Кондиционер выключен");
        }
        public void SetPower(ushort power)
        {
            Power = power;
            Console.WriteLine("Мощность кондиционера установлена на " + Power);
        }
        public void SetMode(ushort mode)
        {
            Mode = mode;
            Console.WriteLine("Режим кондиционера установлен на " + Mode);
        }
    }
}
