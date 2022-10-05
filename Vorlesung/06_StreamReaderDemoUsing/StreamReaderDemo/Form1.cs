using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamReaderDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            string text;

            using (StreamReader reader = new StreamReader("DieGlocke.txt"))
            {
                text = reader.ReadToEnd();
            }

            textBox1.Text = text;
        }
    }
}
