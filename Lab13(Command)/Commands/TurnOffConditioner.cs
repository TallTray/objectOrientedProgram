using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Command_.Commands
{
    public class TurnOffConditioner : ICommand
    {
        private Conditioner _conditioner;
        public TurnOffConditioner(Conditioner conditioner) 
        { 
            _conditioner = conditioner ?? throw new ArgumentNullException(nameof(conditioner));
        }
        public void Execute()
        {
            _conditioner.TurnOff(); 
        }
        public ICommand GetReverseAction()
        {
            return new TurnOnConditioner(_conditioner);
        }
    }
}
