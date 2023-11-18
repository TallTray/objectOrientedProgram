using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Bridge_
{
    public interface IDevice
    {
        public ushort Power { get;}
        public ushort Mode { get; }
        public void On();
        public void Off();
        public void SetPower(ushort power);
        public void SetMode(ushort mode);
    }
}
