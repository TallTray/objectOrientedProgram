using MazeProj;
using RadilovProject;


namespace Lab2
{
    internal class MazeBuilderWithBomb : MazeBuilder
    {
        public override Room BuildRoom(int number)
        {
            if (Maze.ContainsNumber(number))
            {
                throw new ArgumentException("Maze already contains room with this number");
            }
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
