using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Command_
{
    public class Remote
    {
        private Dictionary<string, ICommand> _commands = new();
        private Stack<ICommand> _history = new();
        public void AddCommand(string name, ICommand command)
        {
            _commands.Add(name, command);
        }
        public bool RemoveCommand(string name)
        {
            return _commands.Remove(name);
        }
        public void Execute(string name)
        {
            foreach (var command in _commands.Where(x=> name.Equals(x.Key)))
            {
                command.Value.Execute();
                _history.Push(command.Value);
            }
        }
        public void ExecuteAll()
        {
            foreach (var command in _commands)
            {
                command.Value.Execute();
            }
            _history.Push(new MultiCommand(_commands.Select(x => x.Value).ToList()));
        }
        public bool Undo()
        {
            if (_history.Count == 0)
            {
                return false;
            }
            _history.Pop().GetReverseAction().Execute();
            return true;
        }
    }
}
