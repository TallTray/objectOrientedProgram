using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_Momento_
{
    public class TextEditor
    {
        private string _text = string.Empty;
        public TextEditor(IMomento momento)
        {
            if(momento is TextEditorMomento textMomento)
            {
                _text = textMomento.GetState();
            }
            else
            {
                throw new ArgumentException("Wrong type");
            }
        }
        public string GetState()
        {
            return _text;
        }
        public IMomento CreateMomento()
        {
            return new TextEditorMomento(_text);
        } 
    }
}
