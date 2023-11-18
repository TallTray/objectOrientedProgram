using MazeProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
