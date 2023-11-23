using RadilovProject;


namespace MazeProj
{
    public class RoomWithTrap : Room
    {
        private static Random rnd = new();
        public RoomWithTrap(int roomNumber) : base(roomNumber)
        {
        }
        public override IMapSite Clone()
        {
            RoomWithTrap room = new(RoomNumber);
            foreach (var el in Sides)
            {
                room.SetSide(el.Key, el.Value.Clone());
            }

            return new RoomWithTrap(RoomNumber);
        }
        public override void Enter()
        {
            base.Enter();
            
            if (rnd.Next(2) == 0)
            {
                Console.WriteLine("Все двери закрылись!");
                Sides.OfType<DoorWithTrap>().ToList().ForEach(x => x.Lock());
            }

        }
    }
}
