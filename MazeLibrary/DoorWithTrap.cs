using RadilovProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProj
{
    public class DoorWithTrap : Door
    {
        public bool Locked { get; internal set; }
        public DoorWithTrap(bool opened, Room firstRoom, Room secondRoom) : base(opened, firstRoom, secondRoom)
        {
        }
        public void Lock()
        {
            Locked = true;
            IsOpen = false;
        }
    }
}
