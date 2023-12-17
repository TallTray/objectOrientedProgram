using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_Momento_
{
    public class TextEditorMomento : IMomento
    {
        private string _text;
        private DateTime _date;
        public TextEditorMomento(string text)
        {
            _text = text;
            _date = DateTime.Now;
        }
        public string GetState()
        {
            return _text;
        }
        public DateTime GetDate()
        {
            return _date;
        }
    }
}
