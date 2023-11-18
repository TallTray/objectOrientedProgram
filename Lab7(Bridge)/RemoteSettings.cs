using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Bridge_
{
    public class RemoteSettings
    {
        public ushort Mode { get; init; }
        public ushort Power { get; init; }
        public RemoteSettings(ushort power, ushort mode)
        {
            Power = power;
            Mode = mode;
        }
    }
}
