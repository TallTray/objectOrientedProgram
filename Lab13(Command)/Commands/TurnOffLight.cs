using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Command_.Commands
{
    public class TurnOffLight : ICommand
    {
        public Lamp _lamp;
        public TurnOffLight(Lamp lamp)
        {
            _lamp = lamp ?? throw new ArgumentNullException(nameof(lamp));
        }
        public void Execute()
        {
            _lamp.TurnOff();
        }
        public ICommand GetReverseAction()
        {
            return new TurnOnLight(_lamp);
        }
    }
}
