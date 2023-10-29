using Lab1;

namespace RadilovProject
{
    class Program
    {
        static void Main()
        {
            MazeGame game = new();
            MazeFactory factory = new();
            game.Create(factory);
            Console.ReadLine();
        }
    }

}