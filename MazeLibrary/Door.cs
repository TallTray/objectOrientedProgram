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
        protected Room FirstRoom { get; private set; }
        protected Room SecondRoom { get; private set; }

        public Door(bool opened, Room firstRoom, Room secondRoom)
        {
            if(firstRoom==null || secondRoom == null)
            {
                throw new ArgumentNullException();
            }
            if(firstRoom.RoomNumber == secondRoom.RoomNumber)
            {
                throw new ArgumentException("Rooms must be different");
            }
            this.FirstRoom = firstRoom;
            this.SecondRoom = secondRoom;
            IsOpen = opened;
        }
        public void SetRoom(bool firstRoom,Room room)
        {
            if(room == null)
            {
                throw new ArgumentNullException();
            }
            else if (firstRoom)
            {
                FirstRoom = room;
            }
            else
            {
                SecondRoom = room;
            }

        }
        public void SetOpened(bool opened)
        {
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
        public virtual IMapSite Clone()
        {
            return new Door(IsOpen, FirstRoom, SecondRoom);
        }

    }
}
