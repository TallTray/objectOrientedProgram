using MazeProj;


namespace Lab5_Singleton_
{
    public class MazeWithBombFactorySingleton : MazeWithBombFactory
    {
        public static MazeWithBombFactorySingleton Instance
        {
            get
            {
                _instance ??= new();
                return _instance;
            }
        }
        private static MazeWithBombFactorySingleton? _instance;
        private MazeWithBombFactorySingleton() { }
    }
}
