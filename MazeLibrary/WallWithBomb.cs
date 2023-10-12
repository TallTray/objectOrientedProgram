using RadilovProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProj
{
    public class WallWithBomb : Wall
    {
        public bool Destroyed { get; internal set; }
        public override void Enter()
        {
            if (Destroyed)
            {
                Console.WriteLine("Стена разрушена");
            }
            else
            {
                base.Enter();
            }
        }
    }
}
