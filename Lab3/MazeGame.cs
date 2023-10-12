using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadilovProject;

namespace Lab3
{
    public class MazeGame
    {
        protected Maze Maze { get; init; }
        public MazeGame()
        {
            Maze = new();
        }
        public virtual Maze Create()
        {
            Maze maze = new();
            Room room1 = BuildRoom(1);
            maze.AddRoom(room1);
            Room room2 = BuildRoom(2);
            maze.AddRoom(room2);

            Door door = BuildDoor(1, 2, true);
            room1.SetSide(Direction.North, door);
            room2.SetSide(Direction.South, door);

            room1.SetSide(Direction.East, BuildWall());
            room1.SetSide(Direction.West, BuildWall());
            room1.SetSide(Direction.South, BuildWall());

            room2.SetSide(Direction.West, BuildWall());
            room2.SetSide(Direction.East, BuildWall());
            room2.SetSide(Direction.North, BuildWall());

            return maze;
        }

        public virtual Room BuildRoom(int number)
        {
            Room room = new(number);
            Maze.AddRoom(room);
            return room;
        }
        public virtual Door BuildDoor(int room1, int room2, bool opened)
        {
            return new Door(opened, Maze.RoomNo(room1), Maze.RoomNo(room2));
        }
        public virtual Wall BuildWall()
        {
            return new Wall();
        }
    }
}
