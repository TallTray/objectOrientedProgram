using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Command_.Commands
{
    public class CloseDoor : ICommand
    {
        private Door _door;
        public CloseDoor(Door door)
        {
            _door = door ?? throw new ArgumentNullException(nameof(door));
        }
        public void Execute()
        {
            _door.Close();
        }
        public ICommand GetReverseAction()
        {
            return new OpenDoor(_door);
        }
    }
}
