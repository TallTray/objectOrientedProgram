using MazeProj;
using RadilovProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class MazeWithTrapGame : MazeGame
    {
        public override Room BuildRoom(int number)
        {
            RoomWithTrap room = new(number);
            return room;

        }
        public override Door BuildDoor(Room room1, Room room2, bool opened)
        {
            return new DoorWithTrap(opened, room1, room1);
        }
    }
}
