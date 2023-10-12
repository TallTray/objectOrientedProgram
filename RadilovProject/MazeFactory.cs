using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RadilovProject
{
    public class MazeFactory
    {
        public virtual Room CreateRoom(int roomNo)
        {
            return new Room(roomNo);
        }

        public virtual Door CreateDoor(Room room1, Room room2, bool opened)
        {
            return new Door(opened, room1, room2);
        }

        public virtual Wall CreateWall()
        {
            return new Wall();
        }

        public virtual Maze CreateMaze()
        {
            return new Maze();
        }
    }
}
