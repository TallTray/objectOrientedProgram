using RadilovProject;


namespace MazeProj
{
    public class MazeWithTrapFactory : MazeFactory
    {
        public MazeWithTrapFactory() : base(new RoomWithTrap(0), new DoorWithTrap(false, new Room(0), new Room(1)), new Wall(), new Maze()) { }
    }
}
