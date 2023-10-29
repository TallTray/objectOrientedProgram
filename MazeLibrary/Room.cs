using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadilovProject
{
    public class Room : IMapSite
    {
        public int RoomNumber { get; private init; }
        protected Dictionary<Direction, IMapSite> Sides { get; private set; }
        public virtual void Enter()
        {
            Console.WriteLine("Вы попали в комнату");
        }
        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            Sides = new();

        }
        public IMapSite GetSide(Direction direction)
        {
            return Sides[direction];
        }

        public void SetSide(Direction direction, IMapSite side)
        {
            Sides.Add(direction, side);
        }
        public IMapSite Clone()
        {
            Room room = new(RoomNumber);
            foreach(var el in Sides)
            {
                room.SetSide(el.Key, el.Value.Clone());
            }
            
            return new Room(RoomNumber);
        }
    }
}
