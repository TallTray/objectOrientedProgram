


namespace RadilovProject
{
    public class MazeFactory
    {
        private Room _room;
        private Door _door;
        private Wall _wall;
        private Maze _maze;
        protected MazeFactory(Room room,Door door,Wall wall, Maze maze)
        {
            _room = room;
            _door = door;
            _wall = wall;
            _maze = maze;
        }
        public MazeFactory() : this(new Room(0), new Door(false, new Room(0), new Room(1)), new Wall(), new Maze()) { }
        public virtual Room CreateRoom(int roomNo)
        {
            Room room = (Room)_room.Clone();
            room.SetRoomNo(roomNo);
            return new Room(roomNo);
        }

        public virtual Door CreateDoor(Room room1, Room room2, bool opened)
        {
            Door door = (Door)_door.Clone();
            door.SetRoom(true, room1);
            door.SetRoom(false, room2);
            door.SetOpened(opened);
            return new Door(opened, room1, room2);
        }

        public virtual Wall CreateWall()
        {
            return (Wall)_wall.Clone();
        }

        public virtual Maze CreateMaze()
        {
            return _maze.Clone();
        }
    }
}
