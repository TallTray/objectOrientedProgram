using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_Momento_
{
    public class Store
    {
        private List<IMomento> _momentos = new();
        public void AddMomento(IMomento momento)
        {
            _momentos.Add(momento ?? throw new ArgumentNullException(nameof(momento)));
        }
        public IMomento PreviousMomento()
        {
            if (_momentos.Count > 0)
            {
                return _momentos[_momentos.Count-1];
            }
            else
            {
                throw new InvalidOperationException("List is empty");
            }
        }
        public IMomento GetMomentoByDate(DateTime date)
        {
            return _momentos.FirstOrDefault(x => x.GetDate() == date) ?? throw new NullReferenceException("List does not contain a momento with given date");
        }
    }
}
