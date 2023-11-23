using MazeProj;


namespace Lab5_Singleton_
{
    public class MazeWithTrapFactorySingleton : MazeWithTrapFactory
    {
        public static MazeWithTrapFactorySingleton Instance
        {
            get
            {
                _instance ??= new();
                return _instance;
            }
        }
        private static MazeWithTrapFactorySingleton? _instance;
        private MazeWithTrapFactorySingleton() { }
    }
}
