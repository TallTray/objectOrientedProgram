using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Command_
{
    public class MultiCommand : ICommand
    {
        protected List<ICommand> Сommands { get; init; }
        public MultiCommand(List<ICommand> list)
        {
            Сommands = list ?? throw new ArgumentNullException(nameof(list));
        }
        public void Execute()
        {
            foreach (var command in Сommands)
            {
                command.Execute();
            }
        }
        public ICommand GetReverseAction()
        {
            return new MultiCommand(Сommands.Select(x => x.GetReverseAction()).ToList());
        }
    }
}
