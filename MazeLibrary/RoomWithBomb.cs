using RadilovProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProj
{
    public class RoomWithBomb : Room
    {
        private static Random rnd = new();
        public RoomWithBomb(int roomNumber) : base(roomNumber)
        {

        }

        public override IMapSite Clone()
        {
            RoomWithBomb room = new(RoomNumber);
            foreach (var el in Sides)
            {
                room.SetSide(el.Key, el.Value.Clone());
            }

            return new RoomWithBomb(RoomNumber);
        }
       
        public override void Enter()
        {
            base.Enter();
            if (rnd.Next(2) == 0)
            {
                Console.WriteLine("Произошел взрыв!");
                Sides.OfType<WallWithBomb>().ToList().ForEach(x => x.Destroyed = true);
            }

        }

    }
}
