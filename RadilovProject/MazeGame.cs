using RadilovProject;


namespace Lab1
{
    public class MazeGame
    {
        public virtual void Create(MazeFactory factory)
        {
            Room room1 = factory.CreateRoom(1);
            Room room2 = factory.CreateRoom(2);


            Door door = factory.CreateDoor(room1, room2, true);
            room1.SetSide(Direction.North, door);
            room2.SetSide(Direction.South, door);

            room1.SetSide(Direction.East, factory.CreateWall());
            room1.SetSide(Direction.West, factory.CreateWall());
            room1.SetSide(Direction.South, factory.CreateWall());

            room2.SetSide(Direction.West, factory.CreateWall());
            room2.SetSide(Direction.East, factory.CreateWall());
            room2.SetSide(Direction.North, factory.CreateWall());

        }
    }
}
