using MazeProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
