using RadilovProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadilovProject
{
    public class Maze
    {
        private Dictionary<int, Room> rooms = new();
        public void AddRoom(Room room)
        {
            rooms.Add(room.RoomNumber, room);
        }
        public Room RoomNo(int RoomNumber)
        {
            return rooms[RoomNumber];
        }
    }
}
