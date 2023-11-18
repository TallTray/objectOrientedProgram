using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RadilovProject
{
    public class MazeFactory
    {
        private Room _room;
        private Door _door;
        private Wall _wall;
        private Maze _maze;
        public MazeFactory()
        {
            _room = new Room(0);
            _door = new Door(true, new Room(0), new Room(1));
            _wall = new Wall();
            _maze = new Maze();
        }
        public virtual Room CreateRoom(int roomNo)
        {
            Room room = (Room)_room.Clone();
            room.SetRoomNo(roomNo);
            return new Room(roomNo);
        }

        public virtual Door CreateDoor(Room room1, Room room2, bool opened)
        {
            Door door = (Door)_door.Clone();
            door.SetRoom(true, room1);
            door.SetRoom(false, room2);
            door.SetOpened(opened);
            return new Door(opened, room1, room2);
        }

        public virtual Wall CreateWall()
        {
            return (Wall)_wall.Clone();
        }

        public virtual Maze CreateMaze()
        {
            return _maze.Clone();
        }
    }
}
