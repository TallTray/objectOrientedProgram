using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Command_.Commands
{
    public class TurnOnConditioner : ICommand
    {
        private Conditioner _conditioner;
        public TurnOnConditioner(Conditioner conditioner)
        {
            _conditioner = conditioner ?? throw new ArgumentNullException(nameof(conditioner));
        }
        public void Execute()
        {
            _conditioner.TurnOn();
        }
        public ICommand GetReverseAction()
        {
            return new TurnOffConditioner(_conditioner);
        }
    }
}
