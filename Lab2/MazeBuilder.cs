using RadilovProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class MazeBuilder
    {
        protected Maze Maze { get; init; }
        public MazeBuilder()
        {
            Maze = new();
        }
        public Maze GetMaze()
        {
            return Maze;
        }
        public virtual Room BuildRoom(int number)
        {
            if (Maze.ContainsNumber(number))
            {
                throw new ArgumentException("Maze already contains room with this number");
            }
            Room room = new(number);
            Maze.AddRoom(room);
            return room;
        }
        public virtual Door BuildDoor(int roomNo1, int roomNo2, bool opened)
        {
            if (Maze.ContainsNumber(roomNo1) || Maze.ContainsNumber(roomNo2))
            {
                throw new ArgumentOutOfRangeException();
            }
            return new Door(opened, Maze.RoomNo(roomNo1), Maze.RoomNo(roomNo2));
        }
        public virtual Wall BuildWall()
        {
            return new Wall();
        }
    }
}
