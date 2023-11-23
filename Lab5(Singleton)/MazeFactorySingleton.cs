using RadilovProject;

namespace Lab5_Singleton_
{
    public class MazeFactorySingleton : MazeFactory
    {
        public static MazeFactorySingleton Instance 
        {
            get 
            {
                _instance ??= new();
                return _instance;
            }
        }
        private static MazeFactorySingleton? _instance;
        private MazeFactorySingleton() { }
    }
}
