using RadilovProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProj
{
    public class MazeWithBombFactory : MazeFactory
    {
        public override Wall CreateWall()
        {
            return new WallWithBomb();
        }

        public override Room CreateRoom(int roomNo)
        {
            return new RoomWithBomb(roomNo);
        }
    }
}
