using RadilovProject;


namespace MazeProj
{
    public class MazeWithTrapFactory : MazeFactory
    {
        public MazeWithTrapFactory() : base()
        {
            _room = new RoomWithTrap(0);
            _door = new DoorWithTrap(true, new Room(0), new Room(1));
        }
      
    }
}
