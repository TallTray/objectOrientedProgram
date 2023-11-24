using RadilovProject;


namespace MazeProj
{
    public class MazeWithBombFactory : MazeFactory
    {
        public MazeWithBombFactory() : base(new RoomWithBomb(0), new Door(false, new Room(0), new Room(1)), new WallWithBomb(), new Maze()) { }
    }
}
