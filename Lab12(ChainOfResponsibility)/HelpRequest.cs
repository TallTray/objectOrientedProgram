using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_ChainOfResponsibility_
{
    public class HelpRequest
    {
        public char Symbol { get; }
        public HelpRequest(char symbol)
        {
            Symbol = symbol;
        }
    }
}
