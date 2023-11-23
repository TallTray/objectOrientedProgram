using MazeProj;
using RadilovProject;


namespace Lab3
{
    public class MazeWithTrapGame : MazeGame
    {
        public override Room BuildRoom(int number)
        {
            if (Maze.ContainsNumber(number))
            {
                throw new ArgumentException("Maze already contains room with this number");
            }
            RoomWithTrap room = new(number);
            return room;
        }
        public override Door BuildDoor(int room1,int room2, bool opened)
        {
            if (Maze.ContainsNumber(room1) || Maze.ContainsNumber(room2))
            {
                throw new ArgumentOutOfRangeException();
            }
            return new DoorWithTrap(opened, Maze.RoomNo(room1), Maze.RoomNo(room2));
        }
    }
}
