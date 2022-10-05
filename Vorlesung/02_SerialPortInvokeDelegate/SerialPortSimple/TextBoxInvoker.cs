using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortSimple
{
    class TextBoxInvoker
    {
        public TextBoxInvoker(TextBox textBox, string text)
        {
            _textBox = textBox;
            _text = text;
        }

        public void SetText()
        {
            _textBox.Text = _text;
        }

        private TextBox _textBox;
        private string _text;
    }
}
