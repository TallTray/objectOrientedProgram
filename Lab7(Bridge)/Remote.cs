using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Bridge_
{
    public class Remote
    {
        public IDevice Device { get; private set; }
        public Remote(IDevice device)
        {
            if (device == null) throw new ArgumentNullException(nameof(device));
            Device = device;
        }
        public void SetDevice(IDevice device)
        {
            if (device == null) throw new ArgumentNullException(nameof(device));
            Device = device;
        }
        public void On()
        {
            Device.On();
        }
        public void Off()
        {
            Device.Off();
        }
        public void AddPower()
        {
            Device.SetPower((ushort)(Device.Power + 1));
        }
        public void DecreasePower()
        {
            Device.SetPower((ushort)(Device.Power - 1));
        }
        public void NextMode()
        {
            Device.SetMode((ushort)(Device.Mode + 1));
        }
        public void PrevMode()
        {
            Device.SetMode((ushort)(Device.Mode - 1));
        }
    }
}
