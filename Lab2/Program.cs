using Lab2;

namespace RadilovProject
{
    class Program
    {
        static void Main()
        {
            MazeBuilder builder = new();
            MazeGame mazeGame = new();
            mazeGame.Create(builder);
            builder.GetMaze();

        }
    }

}
