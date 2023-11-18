using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Bridge_
{
    public class RemoteWithMemory : Remote
    {
        public RemoteSettings[] Settings {  get; private set; }
        public RemoteWithMemory(IDevice device) : base(device) 
        {
            Settings = new RemoteSettings[5];
        }
        public void Save(int saveSlot)
        {
            if(saveSlot<0 || saveSlot > Settings.Length)throw new ArgumentOutOfRangeException(nameof(saveSlot));
            Settings[saveSlot] = new RemoteSettings(Device.Power, Device.Mode);
        }
        public void Load(int saveSlot)
        {
            if (saveSlot < 0 || saveSlot > Settings.Length) throw new ArgumentOutOfRangeException(nameof(saveSlot));
            if (Settings[saveSlot] == null)throw new ArgumentNullException("Settings["+ saveSlot + "]");
            Device.SetPower(Settings[saveSlot].Power);
            Device.SetMode(Settings[saveSlot].Mode);
        }
    }
}
