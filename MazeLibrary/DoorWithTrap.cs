using RadilovProject;


namespace MazeProj
{
    public class DoorWithTrap : Door
    {
        public bool Locked { get; internal set; }
        public DoorWithTrap(bool opened, Room firstRoom, Room secondRoom) : base(opened, firstRoom, secondRoom)
        {
        }
        public override IMapSite Clone()
        {
            return new DoorWithTrap(IsOpen, FirstRoom, SecondRoom);
        }
        public void Lock()
        {
            Locked = true;
            IsOpen = false;
        }
    }
}
