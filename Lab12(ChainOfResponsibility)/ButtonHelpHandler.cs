using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_ChainOfResponsibility_
{
    public class ButtonHelpHandler : HelpHandler
    {
        public ButtonHelpHandler(HelpHandler helpHandler)
            : base(helpHandler) { }

        protected override bool IsSupportRequest(HelpRequest helpRequest)
        {
            if (helpRequest == null)
            {
                throw new ArgumentNullException(nameof(helpRequest));
            }
            return char.IsDigit(helpRequest.Symbol) || "+-*/".Contains(helpRequest.Symbol);
        }

        protected override string BuildHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null)
            {
                throw new ArgumentNullException(nameof(helpRequest));
            }
            return "Это кнопка для символа " + helpRequest.Symbol.ToString();
        }
        protected override string BuildDefaultHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null)
            {
                throw new ArgumentNullException(nameof(helpRequest));
            }
            return "Неверное действие";
        }
    }
}
