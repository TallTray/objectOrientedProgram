using MazeProj;
using RadilovProject;


namespace Lab3
{
    public class MazeWithBombGame : MazeGame
    {
        public override Room BuildRoom(int number)
        {
            if (Maze.ContainsNumber(number))
            {
                throw new ArgumentException("Maze already contains room with this number");
            }
            RoomWithBomb room = new(number);
            return room;
        }
        public override Wall BuildWall()
        {
            return new WallWithBomb();
        }
    }
}
