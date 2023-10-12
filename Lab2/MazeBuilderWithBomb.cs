using MazeProj;
using RadilovProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class MazeBuilderWithBomb : MazeBuilder
    {
        public override Room BuildRoom(int number)
        {
            RoomWithBomb room = new(number);
            Maze.AddRoom(room);
            return room;
        }
        public override Wall BuildWall()
        {
            return new WallWithBomb();
        }
    }
}
