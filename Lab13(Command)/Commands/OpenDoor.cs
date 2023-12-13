using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Command_.Commands
{
    public class OpenDoor : ICommand
    {
        private Door _door;
        public OpenDoor(Door door)
        {
            _door = door ?? throw new ArgumentNullException(nameof(door));
        }
        public void Execute()
        {
            _door.Open();
        }
        public ICommand GetReverseAction()
        {
            return new CloseDoor(_door);
        }
    }
}
