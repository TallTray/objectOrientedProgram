using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Command_.Commands
{
    public class TurnOnLight : ICommand
    {
        public Lamp _lamp;
        public TurnOnLight(Lamp lamp)
        {
            _lamp = lamp ?? throw new ArgumentNullException(nameof(lamp));
        }
        public void Execute()
        {
            _lamp.TurnOn();
        }
        public ICommand GetReverseAction()
        {
            return new TurnOffLight(_lamp);
        }
    }
}
