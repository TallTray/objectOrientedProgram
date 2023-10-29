using RadilovProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProj
{
    public class MazeWithTrapFactory : MazeFactory
    {
        public override Room CreateRoom(int roomNo)
        {
            return new RoomWithBomb(roomNo);
        }
        public override Door CreateDoor(Room room1, Room room2, bool opened)
        {
            if (room1 == null || room2 == null)
            {
                throw new ArgumentNullException();
            }
            return new DoorWithTrap(opened, room1, room2);
        }
    }
}
