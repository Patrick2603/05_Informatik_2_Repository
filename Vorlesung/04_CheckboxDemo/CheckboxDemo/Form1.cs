using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string title = "", message = "";
            MessageBoxIcon mbi = MessageBoxIcon.None;
            
            if (checkBoxTitel.Checked)
            {
                title = "Mein Titel";
            }
            if (checkBoxMessage.Checked)
            {
                message = "Meine Nachricht";
            }

            if (radioButtonQuestion.Checked)
            {
                mbi = MessageBoxIcon.Question;
            }
            else if (radioButtonError.Checked)
            {
                mbi = MessageBoxIcon.Error;
            }
            else if (radioButtonInfo.Checked)
            {
                mbi = MessageBoxIcon.Information;
            }

            MessageBox.Show(message, title, MessageBoxButtons.OK, mbi);
        }
    }
}
