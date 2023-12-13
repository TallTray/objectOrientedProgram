using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_ChainOfResponsibility_
{
    public class ApplicationHelpHandler : HelpHandler
    {
        public ApplicationHelpHandler(HelpHandler helpHandler)
            : base(helpHandler) { }

        protected override bool IsSupportRequest(HelpRequest helpRequest)
        {
            if (helpRequest == null)
            {
                throw new ArgumentNullException(nameof(helpRequest)); 
            }
            return true;
        }

        protected override string BuildHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null) 
            { 
                throw new ArgumentNullException(nameof(helpRequest)); 
            }
            return "Неверное действие";
        }

        protected override string BuildDefaultHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null) 
            { 
                throw new ArgumentNullException(nameof(helpRequest)); 
            }
            return $"Добро пожаловать в Калькулятор.";
        }
    }
}
