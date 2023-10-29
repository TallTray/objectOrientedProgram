using MazeProj;
using RadilovProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class MazeBuilderWithTrap : MazeBuilder
    {
        public override Room BuildRoom(int number)
        {
            if (Maze.ContainsNumber(number))
            {
                throw new ArgumentException("Maze already contains room with this number");
            }
            RoomWithTrap room = new(number);
            Maze.AddRoom(room);
            return room;
        }
        public override Door BuildDoor(int roomNo1, int roomNo2, bool opened)
        {
            if (Maze.ContainsNumber(roomNo1) || Maze.ContainsNumber(roomNo2))
            {
                throw new ArgumentOutOfRangeException();
            }
            return new DoorWithTrap(opened, Maze.RoomNo(roomNo1), Maze.RoomNo(roomNo1));
        }
    }
}
