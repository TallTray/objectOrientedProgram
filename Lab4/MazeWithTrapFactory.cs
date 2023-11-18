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
        private RoomWithTrap _room;
        private DoorWithTrap _door;
        public MazeWithTrapFactory() : base()
        {
            _room = new RoomWithTrap(0);
            _door = new DoorWithTrap(true, new Room(0), new Room(1));
        }
        public override RoomWithTrap CreateRoom(int roomNo)
        {
            RoomWithTrap room = (RoomWithTrap)_room.Clone();
            room.SetRoomNo(roomNo);
            return room;
        }
        public override Door CreateDoor(Room room1, Room room2, bool opened)
        {
            DoorWithTrap door = (DoorWithTrap)_door.Clone();
            door.SetRoom(true, room1);
            door.SetRoom(false, room2);
            door.SetOpened(opened);
            return door;
        }
    }
}
