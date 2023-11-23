
using RadilovProject;

namespace Lab2
{
    public class MazeGame
    {
        public virtual void Create(MazeBuilder builder)
        {
            Room room1 = builder.BuildRoom(1);
            Room room2 = builder.BuildRoom(2);


            Door door = builder.BuildDoor(1, 2, true);
            room1.SetSide(Direction.North, door);
            room2.SetSide(Direction.South, door);

            room1.SetSide(Direction.East, builder.BuildWall());
            room1.SetSide(Direction.West, builder.BuildWall());
            room1.SetSide(Direction.South, builder.BuildWall());

            room2.SetSide(Direction.West, builder.BuildWall());
            room2.SetSide(Direction.East, builder.BuildWall());
            room2.SetSide(Direction.North, builder.BuildWall());

        }
    }
}
