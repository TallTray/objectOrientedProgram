using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadilovProject;

namespace RadilovProject
{
    public class Door : IMapSite
    {
        public bool IsOpen { get; internal set; }
        protected Room FirstRoom { get; init; }
        protected Room SecondRoom { get; init; }

        public Door(bool opened, Room firstRoom, Room secondRoom)
        {
            this.FirstRoom = firstRoom;
            this.SecondRoom = secondRoom;
            IsOpen = opened;
        }

        public void Enter()
        {
            if (IsOpen)
            {
                Console.WriteLine("Вы вошли в дверь");
            }
            else
            {
                Console.WriteLine("Дверь заперта");
            }

        }

        public Room OtherSideFrom(Room room)
        {
            if (room.RoomNumber == FirstRoom.RoomNumber)
            {
                return SecondRoom;
            }
            else if (room.RoomNumber == SecondRoom.RoomNumber)
            {
                return FirstRoom;
            }
            else throw new ArgumentOutOfRangeException();
        }
    }
}
