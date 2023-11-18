using RadilovProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MazeProj
{
    public class MazeWithBombFactory : MazeFactory
    {
        private RoomWithBomb _room;
        private WallWithBomb _wall;
        public MazeWithBombFactory() : base()
        {
            _room = new RoomWithBomb(0);
            _wall = new WallWithBomb();
        }
        public override WallWithBomb CreateWall()
        {
            return (WallWithBomb)_wall.Clone();
        }

        public override Room CreateRoom(int roomNo)
        {
            RoomWithBomb room = (RoomWithBomb)_room.Clone();
            room.SetRoomNo(roomNo);
            return room;
        }
    }
}
