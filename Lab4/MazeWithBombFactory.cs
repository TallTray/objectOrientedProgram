using RadilovProject;


namespace MazeProj
{
    public class MazeWithBombFactory : MazeFactory
    {
        public MazeWithBombFactory() : base()
        {
            _room = new RoomWithBomb(0);
            _wall = new WallWithBomb();
        }
        
    }
}
