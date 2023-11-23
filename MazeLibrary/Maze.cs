

namespace RadilovProject
{
    public class Maze
    {
        private Dictionary<int, Room> rooms = new();
        public void AddRoom(Room room)
        {
            if (rooms.ContainsValue(room))
            {
                throw new ArgumentException("Maze already contains this room");
            }
            rooms.Add(room.RoomNumber, room);
        }
        public Room RoomNo(int RoomNumber)
        {
            if (!rooms.ContainsKey(RoomNumber))
            {
                throw new ArgumentOutOfRangeException();
            }
            return rooms[RoomNumber];
        }
        public bool ContainsRoom(Room room)
        {
            return rooms.ContainsValue(room);
        }
        public bool ContainsNumber(int number)
        {
            return rooms.ContainsKey(number);
        }
        public Maze Clone()
        {
            return new Maze();
        }
    }
}
