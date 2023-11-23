using RadilovProject;


namespace MazeProj
{
    public class MazeWithBombFactory : MazeFactory
    {
        public override Wall CreateWall()
        {
            return new WallWithBomb();
        }

        public override Room CreateRoom(int roomNo)
        {
            return new RoomWithBomb(roomNo);
        }
    }
}
